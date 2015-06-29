using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace accelerometer
{
    /// <summary>
    /// AccelDataをリストとして保持するクラス
    /// </summary>
    public class SensorData
    {
        #region メンバ変数
        private dataType currentType;
        //private SensorVer version;
        private List<AccelData> allData;
        private List<byte> dataBuffer;
        //private int bufferindex;
        private const int maximumData = 1000;
        //センサの設定情報
        private SensorConfig sensConfig;
        #region 通信に必要な変数
        //private Dictionary<dataType, int> requiredDataNum;
        //private Dictionary<dataType, byte[]> fixedData;
        #region static
        private static Encoding encoding = Encoding.ASCII;
        #endregion
        #endregion
        #endregion

        #region プロパティ
        #region 静的変数
        /// <summary>
        /// エンコーディング
        /// </summary>
        public static Encoding Encoding
        {
            get
            {
                return SensorData.encoding;
            }
        }
        #endregion
        /// <summary>
        /// センサの設定情報
        /// </summary>
        public SensorConfig Config
        {
            get
            {
                return this.sensConfig;
            }
        }
        ///// <summary>
        ///// 得るデータと受け取るデータの先頭固定バイト
        ///// </summary>
        //public Dictionary<dataType, byte[]> FixedData
        //{
        //    get
        //    {
        //        return this.fixedData;
        //    }
        //}
        ///// <summary>
        ///// 得るデータと配列の個数の関係
        ///// </summary>
        //public Dictionary<dataType,int> RequiredDataNum
        //{
        //    get
        //    {
        //        return this.requiredDataNum;
        //    }
        //}
        
        public List<AccelData> AllData
        {
            get
            {
                return allData;
            }
        }
        /// <summary>
        /// リストに保持されている最後のデータを返す
        /// </summary>
        public AccelData LastData
        {
            get
            {
                return this.allData.Last();
            }
        }
        #endregion


        #region コンストラクタ
        /// <summary>
        /// センサデータを管理するクラス
        /// </summary>
        /// <param name="type">データタイプ（加速度のみ、角速度のみ、両方）</param>
        /// <param name="version">センサの型番</param>
        public SensorData(dataType type, SensorVer version)
        {
            this.currentType = type;
            //this.version = version;
            //this.SensorChange(version);
            //センサの設定情報
            this.sensConfig = new SensorConfig(version);
            //allDataの初期化（必ず必要）
            this.allData = new List<AccelData>();
            //bufferの初期化
            this.dataBuffer = new List<byte>();
        }
        #endregion

        #region メソッド
        #region public
        //public void SensorChange(SensorVer version)
        //{
        //    this.requiredDataNum = new Dictionary<dataType, int>();
        //    this.fixedData = new Dictionary<dataType, byte[]>();
        //    switch (version)
        //    {
        //        case SensorVer.WAA010:
        //            #region 配列の個数
        //            requiredDataNum.Add(dataType.accel, 15);
        //            requiredDataNum.Add(dataType.both, 20);
        //            requiredDataNum.Add(dataType.gyro, 15);
        //            #endregion
        //            #region
        //            byte[] agb = SensorData.Encoding.GetBytes("agb");
        //            byte[] senb = SensorData.Encoding.GetBytes("senb");
        //            byte[] gyb = SensorData.Encoding.GetBytes("gyb");
        //            fixedData.Add(dataType.both, agb);//agb
        //            fixedData.Add(dataType.accel, senb);//senb
        //            fixedData.Add(dataType.gyro, gyb);//gyb
        //            #endregion
        //            break;
        //        case SensorVer.TSND121:
        //            break;
        //    }
        //}
        
        /// <summary>
        /// シリアルポートからのデータを受け取りデータバッファに溜める
        /// もし、加速度データに変更できるだけの量が溜まれば加速度データに変換後、該当データは破棄
        /// </summary>
        /// <param name="data"></param>
        public void pushDataBuffer(byte[] data)
        {
            foreach(byte d in data)
            {
                this.pushDataBuffer(d);
            }
        }
        /// <summary>
        /// SensorDataにAccelDataを追加するメソッド
        /// </summary>
        /// <param name="input">AccelData</param>
        private void pushData(AccelData input)
        {
            this.allData.Add(input);
            //もしデータの個数がmaximumDataを超えたら、リストの最初の値を削除
            if (this.allData.Count > maximumData)
            {
                this.allData.RemoveAt(0);
            }
        }
        /// <summary>
        /// 指定した番号から番号までのデータを返すメソッド
        /// </summary>
        /// <param name="head">頭の番号</param>
        /// <param name="tail">終わりの番号</param>
        /// <returns></returns>
        public List<AccelData> ExtractData(int head,int tail)
        {
            //例外処理
            if (head > tail)
            {
                throw new ArgumentException("head>tailとなる数値が入力されました");
            }
            if (head > this.allData.Count - 1)
            {
                throw new ArgumentOutOfRangeException("head", "蓄積されているデータ数より大きな番号が指定されました。");
            }
            if (tail > this.allData.Count - 1)
            {
                throw new ArgumentOutOfRangeException("tail", "蓄積されているデータ数より大きな番号が指定されました。");
            }
            //
            List<AccelData> result = new List<AccelData>();
            //Console.WriteLine("Extracting");
            //Console.WriteLine("(" + head + "," + tail + ")");
            for (int i = head; i < tail + 1; i++)
            {
                result.Add(this.allData[i]);
            }
            return result;
        }
        /// <summary>
        /// 後ろから指定した数分のデータを返すメソッド
        /// </summary>
        /// <param name="num">指定する数</param>
        /// <returns></returns>
        public List<AccelData> ExtractData(int num)
        {
            int tail = this.allData.Count - 1;
            
            if (this.allData.Count >= num)
            {
                //抽出したい数よりも蓄積されているデータの方が多い場合
                int head = this.allData.Count - num;
                return this.ExtractData(head, tail);
            }
            else
            {
                if (this.allData.Count == 0)
                {
                    //データが一つもないとき
                    return this.allData;
                }
                else
                {
                    //Console.WriteLine("exrtact Data");
                    return this.ExtractData(0, tail);
                }
            }
        }
        /// <summary>
        /// たまっているデータをcsvファイルとして保存する
        /// </summary>
        /// <param name="path">保存先のパス</param>
        /// <param name="enc">エンコード</param>
        /// <param name="isHeader">ヘッダーを入れるかどうか</param>
        public void saveData(string path, Encoding enc, bool isHeader)
        {
            using (StreamWriter sw = new StreamWriter(path, false, enc))
            {
                if (isHeader)
                {
                    switch (this.currentType)
                    {
                        case dataType.both:
                            sw.WriteLine("time,ax,ay,az,gx,gy,gz");
                            break;
                        case dataType.accel:
                            sw.WriteLine("time,ax,ay,az");
                            break;
                        case dataType.gyro:
                            sw.WriteLine("time,gx,gy,gz");
                            break;
                        default:
                            break;
                    }
                }
                foreach (AccelData data in this.allData)
                {
                    sw.WriteLine(data.CSVFormat(this.currentType));
                }
            }
        }
        #endregion
        #region private
        /// <summary>
        /// シリアルポートからのデータを受け取りデータバッファに溜める
        /// もし加速度データに変更できるだけの量が溜まれば加速度データに変換後、該当データは破棄
        /// </summary>
        /// <param name="data"></param>
        private void pushDataBuffer(byte data)
        {
            this.dataBuffer.Add(data);
            this.checkData(this.dataBuffer);
        }
        public bool checkData(List<byte> data)
        {
            //bool result = true;
            //データ数が一定個以下ならfalseを返す
            if (data.Count <= this.sensConfig.RequiredDataNum[this.currentType])
            {
                //result = false;
                return false;
            }
            else
            {
                int num = this.sensConfig.RequiredDataNum[this.currentType];
                int num2 = this.sensConfig.FixedData[this.currentType].Length;
                for (int i = 0; i < num2; i++)
                {
                    if (data[i] != this.sensConfig.FixedData[this.currentType][i])
                    {
                        //result = false;
                        return false;
                    }
                }
                //先頭バイトが合致していればデータに変換して先頭を消去

                List<byte> temp = data.GetRange(0, num);
                this.pushData(new AccelData(temp.ToArray(), this.currentType, this.sensConfig.Version));
                data.RemoveRange(0, num);

                return true;
            }
            //return result;
        }
        #endregion
        #endregion
    }
}
