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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.toolStripStatusLabelConnectCondition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFreq = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOriginal = new System.Windows.Forms.TabPage();
            this.tabPageCustomize = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxVersion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxCOM = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAccel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxGyro.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageOriginal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "加速度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "角速度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "x軸";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "y軸";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "z軸";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(184, 29);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(100, 19);
            this.textBoxX.TabIndex = 9;
            // 
            // textBoxGX
            // 
            this.textBoxGX.Location = new System.Drawing.Point(300, 28);
            this.textBoxGX.Name = "textBoxGX";
            this.textBoxGX.ReadOnly = true;
            this.textBoxGX.Size = new System.Drawing.Size(100, 19);
            this.textBoxGX.TabIndex = 10;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(184, 53);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(100, 19);
            this.textBoxY.TabIndex = 11;
            // 
            // textBoxGY
            // 
            this.textBoxGY.Location = new System.Drawing.Point(300, 53);
            this.textBoxGY.Name = "textBoxGY";
            this.textBoxGY.ReadOnly = true;
            this.textBoxGY.Size = new System.Drawing.Size(100, 19);
            this.textBoxGY.TabIndex = 12;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(184, 79);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(100, 19);
            this.textBoxZ.TabIndex = 13;
            // 
            // textBoxGZ
            // 
            this.textBoxGZ.Location = new System.Drawing.Point(300, 79);
            this.textBoxGZ.Name = "textBoxGZ";
            this.textBoxGZ.ReadOnly = true;
            this.textBoxGZ.Size = new System.Drawing.Size(100, 19);
            this.textBoxGZ.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 298);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "時刻";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(47, 9);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(100, 19);
            this.textBoxTime.TabIndex = 19;
            // 
            // groupBoxAccel
            // 
            this.groupBoxAccel.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxAccel.Location = new System.Drawing.Point(6, 106);
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
            this.groupBoxGyro.Location = new System.Drawing.Point(129, 106);
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelConnectCondition,
            this.toolStripStatusLabelFreq});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(556, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "data num =";
            // 
            // toolStripStatusLabelConnectCondition
            // 
            this.toolStripStatusLabelConnectCondition.Name = "toolStripStatusLabelConnectCondition";
            this.toolStripStatusLabelConnectCondition.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabelConnectCondition.Text = "接続状態：";
            // 
            // toolStripStatusLabelFreq
            // 
            this.toolStripStatusLabelFreq.Name = "toolStripStatusLabelFreq";
            this.toolStripStatusLabelFreq.Size = new System.Drawing.Size(346, 17);
            this.toolStripStatusLabelFreq.Spring = true;
            this.toolStripStatusLabelFreq.Text = "freq = ";
            this.toolStripStatusLabelFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageOriginal);
            this.tabControl1.Controls.Add(this.tabPageCustomize);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 488);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPageOriginal
            // 
            this.tabPageOriginal.Controls.Add(this.trackBar1);
            this.tabPageOriginal.Controls.Add(this.label7);
            this.tabPageOriginal.Controls.Add(this.label1);
            this.tabPageOriginal.Controls.Add(this.label2);
            this.tabPageOriginal.Controls.Add(this.groupBoxGyro);
            this.tabPageOriginal.Controls.Add(this.label3);
            this.tabPageOriginal.Controls.Add(this.pictureBox1);
            this.tabPageOriginal.Controls.Add(this.groupBoxAccel);
            this.tabPageOriginal.Controls.Add(this.label4);
            this.tabPageOriginal.Controls.Add(this.textBoxTime);
            this.tabPageOriginal.Controls.Add(this.label5);
            this.tabPageOriginal.Controls.Add(this.label6);
            this.tabPageOriginal.Controls.Add(this.textBoxX);
            this.tabPageOriginal.Controls.Add(this.textBoxGX);
            this.tabPageOriginal.Controls.Add(this.textBoxY);
            this.tabPageOriginal.Controls.Add(this.textBoxGZ);
            this.tabPageOriginal.Controls.Add(this.textBoxGY);
            this.tabPageOriginal.Controls.Add(this.textBoxZ);
            this.tabPageOriginal.Location = new System.Drawing.Point(4, 22);
            this.tabPageOriginal.Name = "tabPageOriginal";
            this.tabPageOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOriginal.Size = new System.Drawing.Size(524, 462);
            this.tabPageOriginal.TabIndex = 0;
            this.tabPageOriginal.Text = "メインビュー（なるべくこのまま）";
            this.tabPageOriginal.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomize
            // 
            this.tabPageCustomize.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomize.Name = "tabPageCustomize";
            this.tabPageCustomize.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomize.Size = new System.Drawing.Size(473, 462);
            this.tabPageCustomize.TabIndex = 1;
            this.tabPageCustomize.Text = "カスタマイズ用";
            this.tabPageCustomize.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxVersion,
            this.toolStripComboBoxCOM,
            this.toolStripSeparator1,
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripSeparator2,
            this.toolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxVersion
            // 
            this.toolStripComboBoxVersion.Name = "toolStripComboBoxVersion";
            this.toolStripComboBoxVersion.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripComboBoxCOM
            // 
            this.toolStripComboBoxCOM.Name = "toolStripComboBoxCOM";
            this.toolStripComboBoxCOM.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonStart.Text = "スタート";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonStop.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonStop.Text = "ストップ";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonSave.Text = "保存";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "縦軸の拡大率";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(473, 158);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 298);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 565);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "加速度センサを使おう！改";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAccel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxGyro.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageOriginal.ResumeLayout(false);
            this.tabPageOriginal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOriginal;
        private System.Windows.Forms.TabPage tabPageCustomize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnectCondition;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCOM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFreq;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
    }
}

