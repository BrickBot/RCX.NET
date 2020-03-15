namespace WindowsController
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAllInfo = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFloat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericMotorPower = new System.Windows.Forms.NumericUpDown();
            this.btnMotorOff = new System.Windows.Forms.Button();
            this.btnMotorOn = new System.Windows.Forms.Button();
            this.comboMotors = new System.Windows.Forms.ComboBox();
            this.comboDirections = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.btnClearSensor = new System.Windows.Forms.Button();
            this.btnPollSensorValue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericSensorMode = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSensorSlope = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboSensors = new System.Windows.Forms.ComboBox();
            this.comboSensorType = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSelectPrg = new System.Windows.Forms.Button();
            this.btnPlayTone = new System.Windows.Forms.Button();
            this.btnPlaySysSound = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFrecuency = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSystemSound = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMotorPower)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSensorMode)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAllInfo);
            this.tabPage1.Controls.Add(this.btnGetInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Brick Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAllInfo
            // 
            this.txtAllInfo.Location = new System.Drawing.Point(16, 56);
            this.txtAllInfo.Multiline = true;
            this.txtAllInfo.Name = "txtAllInfo";
            this.txtAllInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAllInfo.Size = new System.Drawing.Size(594, 307);
            this.txtAllInfo.TabIndex = 1;
            this.txtAllInfo.WordWrap = false;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(14, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(84, 25);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Get All Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFloat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numericMotorPower);
            this.tabPage2.Controls.Add(this.btnMotorOff);
            this.tabPage2.Controls.Add(this.btnMotorOn);
            this.tabPage2.Controls.Add(this.comboMotors);
            this.tabPage2.Controls.Add(this.comboDirections);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFloat
            // 
            this.btnFloat.Enabled = false;
            this.btnFloat.Location = new System.Drawing.Point(184, 93);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(100, 23);
            this.btnFloat.TabIndex = 7;
            this.btnFloat.Text = "Float";
            this.btnFloat.UseVisualStyleBackColor = true;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motors:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Direction:";
            // 
            // numericMotorPower
            // 
            this.numericMotorPower.Location = new System.Drawing.Point(27, 128);
            this.numericMotorPower.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericMotorPower.Name = "numericMotorPower";
            this.numericMotorPower.Size = new System.Drawing.Size(120, 20);
            this.numericMotorPower.TabIndex = 5;
            this.numericMotorPower.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // btnMotorOff
            // 
            this.btnMotorOff.Enabled = false;
            this.btnMotorOff.Location = new System.Drawing.Point(184, 63);
            this.btnMotorOff.Name = "btnMotorOff";
            this.btnMotorOff.Size = new System.Drawing.Size(100, 23);
            this.btnMotorOff.TabIndex = 4;
            this.btnMotorOff.Text = "Off";
            this.btnMotorOff.UseVisualStyleBackColor = true;
            this.btnMotorOff.Click += new System.EventHandler(this.btnMotorOff_Click);
            // 
            // btnMotorOn
            // 
            this.btnMotorOn.Location = new System.Drawing.Point(184, 34);
            this.btnMotorOn.Name = "btnMotorOn";
            this.btnMotorOn.Size = new System.Drawing.Size(100, 23);
            this.btnMotorOn.TabIndex = 4;
            this.btnMotorOn.Text = "On";
            this.btnMotorOn.UseVisualStyleBackColor = true;
            this.btnMotorOn.Click += new System.EventHandler(this.btnMotorOn_Click);
            // 
            // comboMotors
            // 
            this.comboMotors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotors.FormattingEnabled = true;
            this.comboMotors.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboMotors.Location = new System.Drawing.Point(26, 34);
            this.comboMotors.Name = "comboMotors";
            this.comboMotors.Size = new System.Drawing.Size(93, 21);
            this.comboMotors.TabIndex = 3;
            // 
            // comboDirections
            // 
            this.comboDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDirections.FormattingEnabled = true;
            this.comboDirections.Items.AddRange(new object[] {
            "Forward",
            "Invert",
            "Reward"});
            this.comboDirections.Location = new System.Drawing.Point(26, 81);
            this.comboDirections.Name = "comboDirections";
            this.comboDirections.Size = new System.Drawing.Size(121, 21);
            this.comboDirections.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.stopButton);
            this.tabPage3.Controls.Add(this.startButton);
            this.tabPage3.Controls.Add(this.btnClearSensor);
            this.tabPage3.Controls.Add(this.btnPollSensorValue);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.numericSensorMode);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtSensorSlope);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblType);
            this.tabPage3.Controls.Add(this.comboSensors);
            this.tabPage3.Controls.Add(this.comboSensorType);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(629, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensors";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(310, 76);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(151, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop Polling Sensor Value Changes";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(310, 31);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(151, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start Polling Sensor Value Changes";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // btnClearSensor
            // 
            this.btnClearSensor.Location = new System.Drawing.Point(179, 76);
            this.btnClearSensor.Name = "btnClearSensor";
            this.btnClearSensor.Size = new System.Drawing.Size(75, 23);
            this.btnClearSensor.TabIndex = 8;
            this.btnClearSensor.Text = "Clear Sensor";
            this.btnClearSensor.UseVisualStyleBackColor = true;
            this.btnClearSensor.Click += new System.EventHandler(this.btnClearSensor_Click);
            // 
            // btnPollSensorValue
            // 
            this.btnPollSensorValue.Location = new System.Drawing.Point(179, 31);
            this.btnPollSensorValue.Name = "btnPollSensorValue";
            this.btnPollSensorValue.Size = new System.Drawing.Size(75, 23);
            this.btnPollSensorValue.TabIndex = 7;
            this.btnPollSensorValue.Text = "Poll Sensor";
            this.btnPollSensorValue.UseVisualStyleBackColor = true;
            this.btnPollSensorValue.Click += new System.EventHandler(this.btnPollSensorValue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sensor:";
            // 
            // numericSensorMode
            // 
            this.numericSensorMode.Location = new System.Drawing.Point(13, 156);
            this.numericSensorMode.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericSensorMode.Name = "numericSensorMode";
            this.numericSensorMode.Size = new System.Drawing.Size(143, 20);
            this.numericSensorMode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mode:";
            // 
            // txtSensorSlope
            // 
            this.txtSensorSlope.Location = new System.Drawing.Point(13, 116);
            this.txtSensorSlope.Name = "txtSensorSlope";
            this.txtSensorSlope.Size = new System.Drawing.Size(140, 20);
            this.txtSensorSlope.TabIndex = 3;
            this.txtSensorSlope.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Slope:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 60);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // comboSensors
            // 
            this.comboSensors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSensors.FormattingEnabled = true;
            this.comboSensors.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboSensors.Location = new System.Drawing.Point(13, 31);
            this.comboSensors.Name = "comboSensors";
            this.comboSensors.Size = new System.Drawing.Size(143, 21);
            this.comboSensors.TabIndex = 0;
            // 
            // comboSensorType
            // 
            this.comboSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSensorType.FormattingEnabled = true;
            this.comboSensorType.Items.AddRange(new object[] {
            "None",
            "Switch",
            "Temperature",
            "Light",
            "Angle"});
            this.comboSensorType.Location = new System.Drawing.Point(13, 76);
            this.comboSensorType.Name = "comboSensorType";
            this.comboSensorType.Size = new System.Drawing.Size(143, 21);
            this.comboSensorType.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSelectPrg);
            this.tabPage4.Controls.Add(this.btnPlayTone);
            this.tabPage4.Controls.Add(this.btnPlaySysSound);
            this.tabPage4.Controls.Add(this.txtProgram);
            this.tabPage4.Controls.Add(this.txtTime);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtFrecuency);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtSystemSound);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(629, 380);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Misc";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSelectPrg
            // 
            this.btnSelectPrg.Location = new System.Drawing.Point(135, 180);
            this.btnSelectPrg.Name = "btnSelectPrg";
            this.btnSelectPrg.Size = new System.Drawing.Size(114, 23);
            this.btnSelectPrg.TabIndex = 2;
            this.btnSelectPrg.Text = "Select Program";
            this.btnSelectPrg.UseVisualStyleBackColor = true;
            this.btnSelectPrg.Click += new System.EventHandler(this.btnSelectPrg_Click);
            // 
            // btnPlayTone
            // 
            this.btnPlayTone.Location = new System.Drawing.Point(135, 87);
            this.btnPlayTone.Name = "btnPlayTone";
            this.btnPlayTone.Size = new System.Drawing.Size(114, 23);
            this.btnPlayTone.TabIndex = 2;
            this.btnPlayTone.Text = "Play  Tone";
            this.btnPlayTone.UseVisualStyleBackColor = true;
            this.btnPlayTone.Click += new System.EventHandler(this.btnPlayTone_Click);
            // 
            // btnPlaySysSound
            // 
            this.btnPlaySysSound.Location = new System.Drawing.Point(135, 29);
            this.btnPlaySysSound.Name = "btnPlaySysSound";
            this.btnPlaySysSound.Size = new System.Drawing.Size(114, 23);
            this.btnPlaySysSound.TabIndex = 2;
            this.btnPlaySysSound.Text = "Play  System Sound";
            this.btnPlaySysSound.UseVisualStyleBackColor = true;
            this.btnPlaySysSound.Click += new System.EventHandler(this.btnPlaySysSound_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(18, 183);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(99, 20);
            this.txtProgram.TabIndex = 1;
            this.txtProgram.Text = "0";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(18, 130);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(99, 20);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Program(0-4):";
            // 
            // txtFrecuency
            // 
            this.txtFrecuency.Location = new System.Drawing.Point(18, 90);
            this.txtFrecuency.Name = "txtFrecuency";
            this.txtFrecuency.Size = new System.Drawing.Size(99, 20);
            this.txtFrecuency.TabIndex = 1;
            this.txtFrecuency.Text = "35";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time (0-255):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Frecuency (35-20000):";
            // 
            // txtSystemSound
            // 
            this.txtSystemSound.Location = new System.Drawing.Point(18, 29);
            this.txtSystemSound.Name = "txtSystemSound";
            this.txtSystemSound.Size = new System.Drawing.Size(99, 20);
            this.txtSystemSound.TabIndex = 1;
            this.txtSystemSound.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "System Sound (0-5):";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(97, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 461);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "RCXNET API Tester";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMotorPower)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSensorMode)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtAllInfo;
        private System.Windows.Forms.ComboBox comboDirections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericMotorPower;
        private System.Windows.Forms.Button btnMotorOff;
        private System.Windows.Forms.Button btnMotorOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMotors;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboSensorType;
        private System.Windows.Forms.TextBox txtSensorSlope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericSensorMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearSensor;
        private System.Windows.Forms.Button btnPollSensorValue;
        private System.Windows.Forms.ComboBox comboSensors;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtSystemSound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlayTone;
        private System.Windows.Forms.Button btnPlaySysSound;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtFrecuency;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectPrg;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
    }
}

