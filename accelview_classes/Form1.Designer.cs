namespace accelview_classes
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxGX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxGY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxGZ = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxCOMS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.groupBoxAccel = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.groupBoxGyro = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxGX = new System.Windows.Forms.CheckBox();
            this.checkBoxGY = new System.Windows.Forms.CheckBox();
            this.checkBoxGZ = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAccel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxGyro.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 49);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 67);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 49);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "ストップ";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 122);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 49);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelConnect.Location = new System.Drawing.Point(127, 19);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(82, 24);
            this.labelConnect.TabIndex = 3;
            this.labelConnect.Text = "未接続";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "加速度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "角速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "x軸";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "y軸";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "z軸";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(188, 102);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 19);
            this.textBoxX.TabIndex = 9;
            // 
            // textBoxGX
            // 
            this.textBoxGX.Location = new System.Drawing.Point(304, 101);
            this.textBoxGX.Name = "textBoxGX";
            this.textBoxGX.ReadOnly = true;
            this.textBoxGX.Size = new System.Drawing.Size(100, 19);
            this.textBoxGX.TabIndex = 10;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(188, 126);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 19);
            this.textBoxY.TabIndex = 11;
            // 
            // textBoxGY
            // 
            this.textBoxGY.Location = new System.Drawing.Point(304, 126);
            this.textBoxGY.Name = "textBoxGY";
            this.textBoxGY.ReadOnly = true;
            this.textBoxGY.Size = new System.Drawing.Size(100, 19);
            this.textBoxGY.TabIndex = 12;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(188, 152);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(100, 19);
            this.textBoxZ.TabIndex = 13;
            // 
            // textBoxGZ
            // 
            this.textBoxGZ.Location = new System.Drawing.Point(304, 152);
            this.textBoxGZ.Name = "textBoxGZ";
            this.textBoxGZ.ReadOnly = true;
            this.textBoxGZ.Size = new System.Drawing.Size(100, 19);
            this.textBoxGZ.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 287);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBoxCOMS
            // 
            this.comboBoxCOMS.FormattingEnabled = true;
            this.comboBoxCOMS.Location = new System.Drawing.Point(304, 23);
            this.comboBoxCOMS.Name = "comboBoxCOMS";
            this.comboBoxCOMS.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCOMS.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "COMの選択";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "時刻";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(188, 59);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(100, 19);
            this.textBoxTime.TabIndex = 19;
            // 
            // groupBoxAccel
            // 
            this.groupBoxAccel.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxAccel.Location = new System.Drawing.Point(12, 196);
            this.groupBoxAccel.Name = "groupBoxAccel";
            this.groupBoxAccel.Size = new System.Drawing.Size(117, 46);
            this.groupBoxAccel.TabIndex = 20;
            this.groupBoxAccel.TabStop = false;
            this.groupBoxAccel.Text = "加速度";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxX);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxY);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxZ);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(111, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Checked = true;
            this.checkBoxX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX.Location = new System.Drawing.Point(3, 3);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(31, 16);
            this.checkBoxX.TabIndex = 0;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Checked = true;
            this.checkBoxY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxY.Location = new System.Drawing.Point(40, 3);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(31, 16);
            this.checkBoxY.TabIndex = 1;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Checked = true;
            this.checkBoxZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZ.Location = new System.Drawing.Point(77, 3);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(31, 16);
            this.checkBoxZ.TabIndex = 2;
            this.checkBoxZ.Text = "Z";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            // 
            // groupBoxGyro
            // 
            this.groupBoxGyro.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxGyro.Location = new System.Drawing.Point(135, 196);
            this.groupBoxGyro.Name = "groupBoxGyro";
            this.groupBoxGyro.Size = new System.Drawing.Size(120, 46);
            this.groupBoxGyro.TabIndex = 21;
            this.groupBoxGyro.TabStop = false;
            this.groupBoxGyro.Text = "角速度";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkBoxGX);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxGY);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxGZ);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 15);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 28);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // checkBoxGX
            // 
            this.checkBoxGX.AutoSize = true;
            this.checkBoxGX.Location = new System.Drawing.Point(3, 3);
            this.checkBoxGX.Name = "checkBoxGX";
            this.checkBoxGX.Size = new System.Drawing.Size(31, 16);
            this.checkBoxGX.TabIndex = 0;
            this.checkBoxGX.Text = "X";
            this.checkBoxGX.UseVisualStyleBackColor = true;
            // 
            // checkBoxGY
            // 
            this.checkBoxGY.AutoSize = true;
            this.checkBoxGY.Location = new System.Drawing.Point(40, 3);
            this.checkBoxGY.Name = "checkBoxGY";
            this.checkBoxGY.Size = new System.Drawing.Size(31, 16);
            this.checkBoxGY.TabIndex = 1;
            this.checkBoxGY.Text = "Y";
            this.checkBoxGY.UseVisualStyleBackColor = true;
            // 
            // checkBoxGZ
            // 
            this.checkBoxGZ.AutoSize = true;
            this.checkBoxGZ.Location = new System.Drawing.Point(77, 3);
            this.checkBoxGZ.Name = "checkBoxGZ";
            this.checkBoxGZ.Size = new System.Drawing.Size(31, 16);
            this.checkBoxGZ.TabIndex = 2;
            this.checkBoxGZ.Text = "Z";
            this.checkBoxGZ.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "test.csv";
            this.saveFileDialog1.Filter = "csvファイル(.csv)|*.csv|全てのファイル(*.*)|*.*";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 565);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxGyro);
            this.Controls.Add(this.groupBoxAccel);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCOMS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxGZ);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxGY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxGX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "加速度センサを使おう！改";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAccel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxGyro.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxGX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxGY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxGZ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxCOMS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.GroupBox groupBoxAccel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.GroupBox groupBoxGyro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxGX;
        private System.Windows.Forms.CheckBox checkBoxGY;
        private System.Windows.Forms.CheckBox checkBoxGZ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

