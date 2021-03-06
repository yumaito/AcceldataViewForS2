﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using accelerometer;

namespace accelview_classes
{
    public partial class Form1 : Form
    {
        //Data alldata;
        #region メンバ変数
        SensorData sensorData;
        //bool openFlag;
        delegate void setfocus();

        Color[] colors;
        #endregion
        #region メソッド
        public Form1()
        {
            InitializeComponent();
        }
        #region 初期化処理
        private void Form1_Load(object sender, EventArgs e)
        {
            //利用可能なシリアルポート名の配列を取得する
            string[] PortList = SerialPort.GetPortNames();
            //コンボボックスの中身を消去
            //comboBoxCOMS.Items.Clear();
            toolStripComboBoxCOM.Items.Clear();
            //シリアルポート名をコンボボックスにセットする
            foreach (string name in PortList)
            {
                //comboBoxCOMS.Items.Add(name);
                toolStripComboBoxCOM.Items.Add(name);
            }
            //COMが1個以上あれば1番目を選択状態にしておく
            if(toolStripComboBoxCOM.Items.Count>0)
            {
                toolStripComboBoxCOM.SelectedIndex = 0;
            }
            //if (comboBoxCOMS.Items.Count > 0)
            //{
            //    comboBoxCOMS.SelectedIndex = 0;
            //}
            toolStripComboBoxCOM.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            foreach (SensorVer s in Enum.GetValues(typeof(SensorVer)))
            {
                toolStripComboBoxVersion.Items.Add(Statistics.GetDescription(s));
            }
            toolStripComboBoxVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            if (toolStripComboBoxVersion.Items.Count > 0)
            {
                toolStripComboBoxVersion.SelectedIndex = 0;
            }
            //comboBoxCOMS.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Clear();
            //-----------------------------------------
            //クラスのインスタンス生成
            //各変数の初期化
            //sensorData = new SensorData();
            //-----------------------------------------
            colors = new Color[] { Color.Red, Color.ForestGreen, Color.Blue, Color.Orange, Color.LightSeaGreen, Color.Turquoise };
            checkBoxX.ForeColor = colors[0];
            checkBoxY.ForeColor = colors[1];
            checkBoxZ.ForeColor = colors[2];
            checkBoxGX.ForeColor = colors[3];
            checkBoxGY.ForeColor = colors[4];
            checkBoxGZ.ForeColor = colors[5];
            //描画のちらつき防止
            //ダブルバッファ（あんまり効果わからん）
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //
            this.connectionchange("接続状態：未接続");
            //シリアル通信のエンコード設定
            serialPort1.Encoding = SensorData.Encoding;
        }
        //画面の表示を初期化する
        private void Clear()
        {
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxZ.Text = "";
            textBoxGX.Text = "";
            textBoxGY.Text = "";
            textBoxGZ.Text = "";
        }
        #endregion

        #region シリアル通信関係
        //シリアルデータ取得（ここは解析を高速にするため要修正）
        //データを受け取ったらデータをAccel型に変換ののち、sensorDataオブジェクトにデータを投げる
        //改正案（データを常にバッファにため続ける、別スレッドで溜まったデータを監視、加速度データに変換できるようになれば
        //変換してたまったデータを破棄
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            Invoke((setfocus)delegate()
            {
                byte[] buffer = new byte[serialPort1.ReadBufferSize];
                //string r = serialPort1.ReadExisting();
                //stringで取得されたデータをbyteに変換するような処理を書く
                //byte[] temp = SensorData.Encoding.GetBytes(r);
                int t = serialPort1.Read(buffer, 0, buffer.Length);
                sensorData.pushDataBuffer(buffer);
                //テキストボックスを加速度の値で埋めるメソッド
                this.TextFill(this.sensorData.LastData);
                //
                this.ProcessingByReceive();
                //再描画メソッドを呼び出す
                pictureBox1.Invalidate();
            });
            //labelReceived.Text = "Received Data="+serialPort1.ReadByte
            //byte[] readdata = new byte[15];
        }
        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            this.SerialOpen();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            this.SerialClose();
        }
        private void SerialOpen()
        {
            this.Cursor = Cursors.WaitCursor;
            SensorVer sv = (SensorVer)toolStripComboBoxVersion.SelectedIndex;
            this.connectionchange("接続状態：接続中...");
            //WAA-010で送信するコマンド===================================
            string cmd = "agb +000000000 4 1 0";//waa-010
            //以下の関数で作成することも可能
            //cmd = SensorConfig.MakeCommand(dataType.both, SensorVer.WAA010, 5, 4);
            //==========================================================
            //TSND121で送信するコマンド===================================
            byte[] cm = new byte[]{0x9a,0x13,0x00,
                            0x00,0x01,0x01,0x00,0x00,0x00,
                        0x00,0x00,0x01,0x01,0x00,0x00,0x00};
            byte[] c = SensorConfig.MakeCommand(SensorVer.TSND121, cm);//tsnd121
            //===========================================================
            
            if (!serialPort1.IsOpen)
            {
                //dataTypeを受け取るデータによって変える
                //加速度データと角速度データ両方ならdataType.both,加速度データのみならdataType.accel,角速度データのみならdataType.gyro
                this.sensorData = new SensorData(dataType.both, sv);
                //シリアルポートが開いていないなら
                serialPort1.PortName = toolStripComboBoxCOM.SelectedItem.ToString();
                serialPort1.Open();
                this.connectionchange("接続状態：接続");
                //加速度と角速度をstopされるまで出力する
                switch (sv)
                {
                    case SensorVer.WAA010:
                        serialPort1.WriteLine(cmd);
                        break;
                    case SensorVer.TSND121:
                        serialPort1.Write(c, 0, c.Length);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.connectionchange("接続状態：接続"); ;
                //加速度と角速度をstopされるまで出力する
                switch (sv)
                {
                    case SensorVer.WAA010:
                        serialPort1.WriteLine(cmd);
                        break;
                    case SensorVer.TSND121:
                        serialPort1.Write(c, 0, c.Length);
                        break;
                    default:
                        break;
                }
            }
            this.Cursor = Cursors.Default;
        }
        private void SerialClose()
        {
            if (serialPort1.IsOpen)
            {
                //シリアルポートが開いているなら
                //切断する処理を行う
                serialPort1.Write("stop all \n");
                this.connectionchange("接続状態：接続"); ;
                //serialPort1.Close();

                //serialPort1.Close();
                //labelConnect.Text = "未接続";
            }
        }
        #endregion

        #region 画面への描画など
        private void connectionchange(string str)
        {
            toolStripStatusLabelConnectCondition.Text = str;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Invalidate();
        }
        /// <summary>
        /// テキストボックスへの描画
        /// </summary>
        /// <param name="data"></param>
        private void TextFill(AccelData data)
        {
            textBoxTime.Text = data.Time.ToString();
            textBoxX.Text = data.Accel.X.ToString();
            textBoxY.Text = data.Accel.Y.ToString();
            textBoxZ.Text = data.Accel.Z.ToString();
            toolStripStatusLabel1.Text = "data num = " + this.sensorData.AllData.Count.ToString();
            textBoxGX.Text = data.Gyro.X.ToString();
            textBoxGY.Text = data.Gyro.Y.ToString();
            textBoxGZ.Text = data.Gyro.Z.ToString();
        }
        private void DrawGraphs(Graphics g, int ratio)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            Pen penBlack = new Pen(Color.Black, 1);
            SolidBrush[] brushes = new SolidBrush[6];
            Pen[] pens = new Pen[6];
            for (int i = 0; i < 6; i++)
            {
                pens[i] = new Pen(colors[i], 1);
                brushes[i] = new SolidBrush(colors[i]);
            }
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            //時間軸描画
            //g.DrawLine(penBlack, new Point(0, h / 2), new Point(w, h / 2));
            //描画する分のSensorDataを取得--------------------------------
            AccelData[] drawnData = sensorData.ExtractData(w).ToArray();
            //------------------------------------------------------------
            //drawnの左側を0で埋める（右詰状態にしてから描画する）
            drawnData = this.FillData(drawnData, w);
            //チェックボックスにチェックがついている値をグラフにして描画する。
            
            //label7.Text = ratio.ToString();
            for (int i = 1; i < w; i++)
            {
                //1つずつコントロールの名前を書くのは面倒なので、ループ処理でできるようにAccelDataクラスとXYZDataクラスに数字を指定して目的の値を返すメソッドを追加。
                //これでforループっぽいもので書くことができる。
                foreach (CheckBox cb in flowLayoutPanel1.Controls)
                {
                    //flowlayoutPanel1に含まれるチェックボックスでループ
                    //cbが各チェックボックスを表す
                    //cb.TabIndexが割り当てられている番号
                    if (cb.Checked)
                    {
                        //TabIndexはXが0、Yが1、Zが2になっているので、チェックボックスのTabIndexを引数にしてAcccelDataクラスから値を取得する
                        int preY = this.AdjustY(drawnData[i - 1].ReturnByNumber(cb.TabIndex), h, ratio);
                        int Y = this.AdjustY(drawnData[i].ReturnByNumber(cb.TabIndex), h, ratio);
                        g.DrawLine(pens[cb.TabIndex], new Point(i - 1, preY), new Point(i, Y));
                        //if (checkBoxMean.Checked)
                        //{

                        //}
                    }
                }
                foreach (CheckBox cb in flowLayoutPanel2.Controls)
                {
                    //flowlayoutPanel2に含まれるチェックボックスでループ
                    if (cb.Checked)
                    {
                        //加速度と同じくTabIndexが0でX、1でY、2でZなので、それに3を足した値（3、4、5）で角速度の値を取得できる。
                        int preY = this.AdjustY(drawnData[i - 1].ReturnByNumber(cb.TabIndex + 3), h, ratio);
                        int Y = this.AdjustY(drawnData[i].ReturnByNumber(cb.TabIndex + 3), h, ratio);
                        g.DrawLine(pens[cb.TabIndex + 3], new Point(i - 1, preY), new Point(i, Y));
                    }
                }
            }
            //ウィンドウの右端に大き目の●を描画
            int radius = 7;
            foreach (CheckBox cb in flowLayoutPanel1.Controls)
            {
                if (cb.Checked)
                {
                    int Y = this.AdjustY(drawnData[drawnData.Length - 1].ReturnByNumber(cb.TabIndex), h, ratio);
                    g.FillEllipse(brushes[cb.TabIndex], w - 2 * radius, Y - radius, 2 * radius, 2 * radius);
                }
            }
            foreach (CheckBox cb in flowLayoutPanel2.Controls)
            {
                if (cb.Checked)
                {
                    int Y = this.AdjustY(drawnData[drawnData.Length - 1].ReturnByNumber(cb.TabIndex + 3), h, ratio);
                    g.FillEllipse(brushes[cb.TabIndex + 3], w - 2 * radius, Y - radius, 2 * radius, 2 * radius);
                }
            }
        }
        /// <summary>
        /// pictureBoxの幅に合わせて、drawの左側を0で埋めるメソッド
        /// </summary>
        /// <param name="drawn"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        private AccelData[] FillData(AccelData[] drawn, int w)
        {
            AccelData[] result = new AccelData[w];
            //wとdrawnの差（取得データの書き出し位置）
            int offset = w - drawn.Length;
            if (offset < 0)
            {
                offset = 0;
            }
            for (int i = 0; i < w; i++)
            {
                if (i < offset)
                {
                    //0を入れる
                    result[i] = new AccelData(0, new XYZData(), new XYZData());
                }
                else
                {
                    result[i] = drawn[i - offset];
                }
            }
            return result;
        }
        /// <summary>
        /// pictureBoxの縦方向の座標を変換するメソッド
        /// 中央を原点、上向きをプラスにする
        /// </summary>
        /// <param name="y">補正元となる値</param>
        /// <param name="h">画面の縦</param>
        /// <param name="ratio">縮小率</param>
        /// <returns></returns>
        private int AdjustY(int y, int h, int ratio)
        {
            //int result = h / 2 - y;
            return h / 2 - y / ratio;
        }
        private void BasicDraw(Graphics g)
        {
            //基本描画
            Pen penBlack = new Pen(Color.Black, 1);
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            //時間軸描画
            g.DrawLine(penBlack, new Point(0, h / 2), new Point(w, h / 2));
        }
        /// <summary>
        /// 再描画メソッド（再描画（ウィンドウで隠れたりなど）が必要なときに呼ばれるメソッド、
        /// 直接命令を送って再描画させることも可能）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            this.BasicDraw(e.Graphics);
            if (this.sensorData != null)
            {
                //trackBarの値から縮小率を算出
                int ratio = (trackBar1.Value - trackBar1.Minimum) * (1 - 50) / (trackBar1.Maximum - trackBar1.Minimum) + 50;
                this.DrawGraphs(e.Graphics, ratio);
            }
        }

        #region その他データ受信毎に実行されるメソッド
        private void ProcessingByReceive()
        {
            toolStripStatusLabelFreq.Text = "freq = " + sensorData.CurrentFreq.ToString("####.##") + "Hz";
            //double[] means = Statistics.Mean(sensorData.AllData);
            //textBoxDataView.Text += "加速度(x,y,z),角速度(x,y,z)=";
            //for (int i = 0; i < means.Length; i++)
            //{
            //    textBoxDataView.Text += means[i].ToString("0.0") + ",";
            //}
            //textBoxDataView.Text += "\n";
        }
        #endregion
        #endregion

        #region 保存関係
        //private void buttonSave_Click(object sender, EventArgs e)
        //{
            
        //}

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            //alldata = new Data();
            //int time = 0;
            //int rtime = 0;
            //double t = 1.0;
            //double t1 = 1.0;
            //double t2 = 1.0;
            //TMP temp = new TMP(time, rtime, t, t1, t2);
            //alldata.PushData(new TMP(time, rtime, t, t1, t2));
            //alldata.PushData(temp);

            //int num = alldata.D[0].Time;
            //alldata.D[0].Time = 0;

            //センサの読み取りをストップしてから保存処理
            if (serialPort1.IsOpen)
            {
                //シリアルポートが開いているなら
                //切断する処理を行う
                serialPort1.Write("stop all \n");
                //serialPort1.Close();
                toolStripStatusLabelConnectCondition.Text = "接続状態：未接続";
                //labelConnect.Text = "未接続";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Encoding enc = Encoding.UTF8;
                    //
                    this.sensorData.saveData(saveFileDialog1.FileName, enc, true);
                    //using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, enc))
                    //{
                    //    //for (int i = 0; i < sensorData.AllData.Count; i++)
                    //    //{
                    //    //    sw.WriteLine(sensorData.AllData[i].CSVFormat(sensorData.AllData[0].D));
                    //    //}
                    //}
                }
            }
        }
        #endregion

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        

        



        #endregion

        

        

        //private void label7_Click(object sender, EventArgs e)
        //{

        //}

        //private void comboBoxCOMS_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
        
}
