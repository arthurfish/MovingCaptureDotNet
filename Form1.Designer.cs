using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MovingCaptureDotNet
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButtion = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.returnToZeroButton = new System.Windows.Forms.Button();
            this.moveSpeedInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stepSizeInput = new System.Windows.Forms.NumericUpDown();
            this.exposureTimeInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positionXLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.positionYLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.moveToStartPosition = new System.Windows.Forms.Button();
            this.moveToEndPosition = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.captureNumberInput = new System.Windows.Forms.NumericUpDown();
            this.caputureStartButton = new System.Windows.Forms.Button();
            this.startX0Input = new System.Windows.Forms.NumericUpDown();
            this.startY0Input = new System.Windows.Forms.NumericUpDown();
            this.endY1Input = new System.Windows.Forms.NumericUpDown();
            this.endX1Input = new System.Windows.Forms.NumericUpDown();
            this.captureProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.commandApplyProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.startX0InputCopy = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.startY0InputCopy = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.startZ0Input = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.motionRemoveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.deltaZInputPolar = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addPolarCoordButton = new System.Windows.Forms.Button();
            this.polarCoordStepsInput = new System.Windows.Forms.NumericUpDown();
            this.deltaRlable = new System.Windows.Forms.Label();
            this.thetaInput = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.deltaRInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.deltaZInputRect = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addRectCoordButton = new System.Windows.Forms.Button();
            this.rectCoordStepsInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.deltaXInput = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.deltaYInput = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.currentHeight = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.HeightDownButton = new System.Windows.Forms.Button();
            this.HeightZeroButton = new System.Windows.Forms.Button();
            this.heightStepSize = new System.Windows.Forms.NumericUpDown();
            this.HeightUpButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSpeedInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepSizeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeInput)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX1Input)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startX0InputCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY0InputCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startZ0Input)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaZInputPolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarCoordStepsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaZInputRect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectCoordStepsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaYInput)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightStepSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(780, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1310, 1091);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.moveDownButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.moveUpButtion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.moveLeftButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.moveRightButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.returnToZeroButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 630);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 147);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(116, 99);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(106, 44);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "后";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButtion
            // 
            this.moveUpButtion.Location = new System.Drawing.Point(116, 3);
            this.moveUpButtion.Name = "moveUpButtion";
            this.moveUpButtion.Size = new System.Drawing.Size(106, 42);
            this.moveUpButtion.TabIndex = 2;
            this.moveUpButtion.Text = "前";
            this.moveUpButtion.UseVisualStyleBackColor = true;
            this.moveUpButtion.Click += new System.EventHandler(this.moveUpButtion_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(3, 51);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(106, 42);
            this.moveLeftButton.TabIndex = 2;
            this.moveLeftButton.Text = "左";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(229, 51);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(107, 42);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "右";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // returnToZeroButton
            // 
            this.returnToZeroButton.Location = new System.Drawing.Point(116, 51);
            this.returnToZeroButton.Name = "returnToZeroButton";
            this.returnToZeroButton.Size = new System.Drawing.Size(106, 42);
            this.returnToZeroButton.TabIndex = 3;
            this.returnToZeroButton.Text = "水平归零";
            this.returnToZeroButton.UseVisualStyleBackColor = true;
            this.returnToZeroButton.Click += new System.EventHandler(this.returnToZeroButton_Click_1);
            // 
            // moveSpeedInput
            // 
            this.moveSpeedInput.DecimalPlaces = 3;
            this.moveSpeedInput.Location = new System.Drawing.Point(164, 2);
            this.moveSpeedInput.Margin = new System.Windows.Forms.Padding(2);
            this.moveSpeedInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.moveSpeedInput.Name = "moveSpeedInput";
            this.moveSpeedInput.Size = new System.Drawing.Size(114, 28);
            this.moveSpeedInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "水平移动速度(mm/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "水平移动步长(mm)";
            // 
            // stepSizeInput
            // 
            this.stepSizeInput.DecimalPlaces = 3;
            this.stepSizeInput.Location = new System.Drawing.Point(164, 38);
            this.stepSizeInput.Margin = new System.Windows.Forms.Padding(2);
            this.stepSizeInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.stepSizeInput.Name = "stepSizeInput";
            this.stepSizeInput.Size = new System.Drawing.Size(114, 28);
            this.stepSizeInput.TabIndex = 5;
            // 
            // exposureTimeInput
            // 
            this.exposureTimeInput.Location = new System.Drawing.Point(164, 74);
            this.exposureTimeInput.Margin = new System.Windows.Forms.Padding(2);
            this.exposureTimeInput.Maximum = new decimal(new int[] {
            9999000,
            0,
            0,
            0});
            this.exposureTimeInput.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.exposureTimeInput.Name = "exposureTimeInput";
            this.exposureTimeInput.Size = new System.Drawing.Size(114, 28);
            this.exposureTimeInput.TabIndex = 5;
            this.exposureTimeInput.Value = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.exposureTimeInput.ValueChanged += new System.EventHandler(this.exposureTimeInput_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "曝光时间(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "水平X坐标(mm): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "水平Y坐标(mm): ";
            // 
            // positionXLable
            // 
            this.positionXLable.AutoSize = true;
            this.positionXLable.Location = new System.Drawing.Point(255, 0);
            this.positionXLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionXLable.Name = "positionXLable";
            this.positionXLable.Size = new System.Drawing.Size(17, 18);
            this.positionXLable.TabIndex = 7;
            this.positionXLable.Text = "0";
            this.positionXLable.Click += new System.EventHandler(this.positionXLable_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.71523F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.28477F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.moveSpeedInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.stepSizeInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.exposureTimeInput, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(369, 633);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(380, 110);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.positionXLable, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.positionYLable, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(368, 754);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 56);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // positionYLable
            // 
            this.positionYLable.AutoSize = true;
            this.positionYLable.Location = new System.Drawing.Point(255, 28);
            this.positionYLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionYLable.Name = "positionYLable";
            this.positionYLable.Size = new System.Drawing.Size(17, 18);
            this.positionYLable.TabIndex = 7;
            this.positionYLable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "拍照起始位置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "x(mm)";
            // 
            // moveToStartPosition
            // 
            this.moveToStartPosition.Location = new System.Drawing.Point(317, 34);
            this.moveToStartPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToStartPosition.Name = "moveToStartPosition";
            this.moveToStartPosition.Size = new System.Drawing.Size(61, 26);
            this.moveToStartPosition.TabIndex = 4;
            this.moveToStartPosition.Text = "移动";
            this.moveToStartPosition.UseVisualStyleBackColor = true;
            this.moveToStartPosition.Click += new System.EventHandler(this.moveToStartPosition_Click_1);
            // 
            // moveToEndPosition
            // 
            this.moveToEndPosition.Location = new System.Drawing.Point(317, 66);
            this.moveToEndPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToEndPosition.Name = "moveToEndPosition";
            this.moveToEndPosition.Size = new System.Drawing.Size(61, 26);
            this.moveToEndPosition.TabIndex = 13;
            this.moveToEndPosition.Text = "移动";
            this.moveToEndPosition.UseVisualStyleBackColor = true;
            this.moveToEndPosition.Click += new System.EventHandler(this.moveToEndPosition_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "拍照终止位置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 938);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "拍照数量";
            // 
            // captureNumberInput
            // 
            this.captureNumberInput.Location = new System.Drawing.Point(589, 931);
            this.captureNumberInput.Margin = new System.Windows.Forms.Padding(2);
            this.captureNumberInput.Name = "captureNumberInput";
            this.captureNumberInput.Size = new System.Drawing.Size(60, 28);
            this.captureNumberInput.TabIndex = 7;
            // 
            // caputureStartButton
            // 
            this.caputureStartButton.Location = new System.Drawing.Point(662, 931);
            this.caputureStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.caputureStartButton.Name = "caputureStartButton";
            this.caputureStartButton.Size = new System.Drawing.Size(88, 32);
            this.caputureStartButton.TabIndex = 20;
            this.caputureStartButton.Text = "开始";
            this.caputureStartButton.UseVisualStyleBackColor = true;
            this.caputureStartButton.Click += new System.EventHandler(this.caputureStartButton_Click);
            // 
            // startX0Input
            // 
            this.startX0Input.DecimalPlaces = 3;
            this.startX0Input.Location = new System.Drawing.Point(132, 34);
            this.startX0Input.Margin = new System.Windows.Forms.Padding(2);
            this.startX0Input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.startX0Input.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.startX0Input.Name = "startX0Input";
            this.startX0Input.Size = new System.Drawing.Size(87, 28);
            this.startX0Input.TabIndex = 7;
            // 
            // startY0Input
            // 
            this.startY0Input.DecimalPlaces = 3;
            this.startY0Input.Location = new System.Drawing.Point(229, 34);
            this.startY0Input.Margin = new System.Windows.Forms.Padding(2);
            this.startY0Input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.startY0Input.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.startY0Input.Name = "startY0Input";
            this.startY0Input.Size = new System.Drawing.Size(84, 28);
            this.startY0Input.TabIndex = 21;
            // 
            // endY1Input
            // 
            this.endY1Input.DecimalPlaces = 3;
            this.endY1Input.Location = new System.Drawing.Point(229, 66);
            this.endY1Input.Margin = new System.Windows.Forms.Padding(2);
            this.endY1Input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.endY1Input.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.endY1Input.Name = "endY1Input";
            this.endY1Input.Size = new System.Drawing.Size(84, 28);
            this.endY1Input.TabIndex = 21;
            // 
            // endX1Input
            // 
            this.endX1Input.DecimalPlaces = 3;
            this.endX1Input.Location = new System.Drawing.Point(132, 66);
            this.endX1Input.Margin = new System.Windows.Forms.Padding(2);
            this.endX1Input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.endX1Input.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.endX1Input.Name = "endX1Input";
            this.endX1Input.Size = new System.Drawing.Size(87, 28);
            this.endX1Input.TabIndex = 7;
            // 
            // captureProgressBar
            // 
            this.captureProgressBar.Location = new System.Drawing.Point(368, 974);
            this.captureProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.captureProgressBar.Name = "captureProgressBar";
            this.captureProgressBar.Size = new System.Drawing.Size(382, 20);
            this.captureProgressBar.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.26854F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.6513F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.24649F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83367F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.endY1Input, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.startX0Input, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.endX1Input, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.moveToEndPosition, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.startY0Input, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.moveToStartPosition, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(368, 823);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(382, 98);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "y(mm)";
            // 
            // commandListBox
            // 
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 18;
            this.commandListBox.Location = new System.Drawing.Point(3, 27);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.ScrollAlwaysVisible = true;
            this.commandListBox.Size = new System.Drawing.Size(333, 580);
            this.commandListBox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.commandApplyProgressBar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.motionRemoveButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.commandListBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 603);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "移动命令";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // commandApplyProgressBar
            // 
            this.commandApplyProgressBar.Location = new System.Drawing.Point(355, 568);
            this.commandApplyProgressBar.Name = "commandApplyProgressBar";
            this.commandApplyProgressBar.Size = new System.Drawing.Size(372, 18);
            this.commandApplyProgressBar.TabIndex = 33;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Location = new System.Drawing.Point(355, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 133);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "开始位置";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.startX0InputCopy, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.startY0InputCopy, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.startZ0Input, 1, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(273, 86);
            this.tableLayoutPanel7.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 18);
            this.label26.TabIndex = 29;
            this.label26.Text = "z(mm)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 18);
            this.label23.TabIndex = 11;
            this.label23.Text = "x(mm)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 18);
            this.label24.TabIndex = 11;
            this.label24.Text = "y(mm)";
            // 
            // startX0InputCopy
            // 
            this.startX0InputCopy.DecimalPlaces = 3;
            this.startX0InputCopy.Location = new System.Drawing.Point(94, 3);
            this.startX0InputCopy.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.startX0InputCopy.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.startX0InputCopy.Name = "startX0InputCopy";
            this.startX0InputCopy.Size = new System.Drawing.Size(84, 28);
            this.startX0InputCopy.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(185, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 18);
            this.label22.TabIndex = 17;
            // 
            // startY0InputCopy
            // 
            this.startY0InputCopy.DecimalPlaces = 3;
            this.startY0InputCopy.Location = new System.Drawing.Point(94, 37);
            this.startY0InputCopy.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.startY0InputCopy.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.startY0InputCopy.Name = "startY0InputCopy";
            this.startY0InputCopy.Size = new System.Drawing.Size(84, 28);
            this.startY0InputCopy.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(185, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 24);
            this.button7.TabIndex = 4;
            this.button7.Text = "移动至此";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.moveToStartPosition_Click_1);
            // 
            // startZ0Input
            // 
            this.startZ0Input.DecimalPlaces = 3;
            this.startZ0Input.Location = new System.Drawing.Point(94, 71);
            this.startZ0Input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.startZ0Input.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            -2147483648});
            this.startZ0Input.Name = "startZ0Input";
            this.startZ0Input.Size = new System.Drawing.Size(84, 28);
            this.startZ0Input.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(372, 27);
            this.button5.TabIndex = 31;
            this.button5.Text = "开始采集";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // motionRemoveButton
            // 
            this.motionRemoveButton.Location = new System.Drawing.Point(355, 482);
            this.motionRemoveButton.Name = "motionRemoveButton";
            this.motionRemoveButton.Size = new System.Drawing.Size(372, 27);
            this.motionRemoveButton.TabIndex = 30;
            this.motionRemoveButton.Text = "移除移动";
            this.motionRemoveButton.UseVisualStyleBackColor = true;
            this.motionRemoveButton.Click += new System.EventHandler(this.motionRemoveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Location = new System.Drawing.Point(355, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 130);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "极坐标移动";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.deltaZInputPolar, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label16, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.addPolarCoordButton, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.polarCoordStepsInput, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.deltaRlable, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.thetaInput, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label19, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.deltaRInput, 2, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(348, 108);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // deltaZInputPolar
            // 
            this.deltaZInputPolar.DecimalPlaces = 3;
            this.deltaZInputPolar.Location = new System.Drawing.Point(88, 70);
            this.deltaZInputPolar.Margin = new System.Windows.Forms.Padding(2);
            this.deltaZInputPolar.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaZInputPolar.Name = "deltaZInputPolar";
            this.deltaZInputPolar.Size = new System.Drawing.Size(90, 28);
            this.deltaZInputPolar.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(2, 68);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 18);
            this.label25.TabIndex = 29;
            this.label25.Text = "Δz (mm)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 18);
            this.label16.TabIndex = 29;
            this.label16.Text = "指令";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "θ (Deg)";
            // 
            // addPolarCoordButton
            // 
            this.addPolarCoordButton.Location = new System.Drawing.Point(234, 36);
            this.addPolarCoordButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPolarCoordButton.Name = "addPolarCoordButton";
            this.addPolarCoordButton.Size = new System.Drawing.Size(90, 27);
            this.addPolarCoordButton.TabIndex = 27;
            this.addPolarCoordButton.Text = "添加";
            this.addPolarCoordButton.UseVisualStyleBackColor = true;
            this.addPolarCoordButton.Click += new System.EventHandler(this.addPolarCoordButton_Click);
            // 
            // polarCoordStepsInput
            // 
            this.polarCoordStepsInput.Location = new System.Drawing.Point(234, 2);
            this.polarCoordStepsInput.Margin = new System.Windows.Forms.Padding(2);
            this.polarCoordStepsInput.Name = "polarCoordStepsInput";
            this.polarCoordStepsInput.Size = new System.Drawing.Size(90, 28);
            this.polarCoordStepsInput.TabIndex = 27;
            // 
            // deltaRlable
            // 
            this.deltaRlable.AutoSize = true;
            this.deltaRlable.Location = new System.Drawing.Point(3, 34);
            this.deltaRlable.Name = "deltaRlable";
            this.deltaRlable.Size = new System.Drawing.Size(80, 18);
            this.deltaRlable.TabIndex = 1;
            this.deltaRlable.Text = "Δr (mm)";
            // 
            // thetaInput
            // 
            this.thetaInput.DecimalPlaces = 3;
            this.thetaInput.Location = new System.Drawing.Point(89, 3);
            this.thetaInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.thetaInput.Name = "thetaInput";
            this.thetaInput.Size = new System.Drawing.Size(90, 28);
            this.thetaInput.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "步数";
            // 
            // deltaRInput
            // 
            this.deltaRInput.DecimalPlaces = 3;
            this.deltaRInput.Location = new System.Drawing.Point(89, 37);
            this.deltaRInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaRInput.Name = "deltaRInput";
            this.deltaRInput.Size = new System.Drawing.Size(90, 28);
            this.deltaRInput.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(352, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 132);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "直角坐标移动";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.deltaZInputRect, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label15, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.addRectCoordButton, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.rectCoordStepsInput, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.deltaXInput, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.deltaYInput, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(348, 102);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // deltaZInputRect
            // 
            this.deltaZInputRect.DecimalPlaces = 3;
            this.deltaZInputRect.Location = new System.Drawing.Point(88, 70);
            this.deltaZInputRect.Margin = new System.Windows.Forms.Padding(2);
            this.deltaZInputRect.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaZInputRect.Name = "deltaZInputRect";
            this.deltaZInputRect.Size = new System.Drawing.Size(90, 28);
            this.deltaZInputRect.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 18);
            this.label18.TabIndex = 28;
            this.label18.Text = "Δz (mm)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 29;
            this.label15.Text = "指令";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Δx (mm)";
            // 
            // addRectCoordButton
            // 
            this.addRectCoordButton.Location = new System.Drawing.Point(234, 36);
            this.addRectCoordButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRectCoordButton.Name = "addRectCoordButton";
            this.addRectCoordButton.Size = new System.Drawing.Size(90, 27);
            this.addRectCoordButton.TabIndex = 27;
            this.addRectCoordButton.Text = "添加";
            this.addRectCoordButton.UseVisualStyleBackColor = true;
            this.addRectCoordButton.Click += new System.EventHandler(this.addRectCoordButton_Click);
            // 
            // rectCoordStepsInput
            // 
            this.rectCoordStepsInput.Location = new System.Drawing.Point(234, 2);
            this.rectCoordStepsInput.Margin = new System.Windows.Forms.Padding(2);
            this.rectCoordStepsInput.Name = "rectCoordStepsInput";
            this.rectCoordStepsInput.Size = new System.Drawing.Size(90, 28);
            this.rectCoordStepsInput.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Δy (mm)";
            // 
            // deltaXInput
            // 
            this.deltaXInput.DecimalPlaces = 3;
            this.deltaXInput.Location = new System.Drawing.Point(89, 3);
            this.deltaXInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaXInput.Name = "deltaXInput";
            this.deltaXInput.Size = new System.Drawing.Size(90, 28);
            this.deltaXInput.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "步数";
            // 
            // deltaYInput
            // 
            this.deltaYInput.DecimalPlaces = 3;
            this.deltaYInput.Location = new System.Drawing.Point(89, 37);
            this.deltaYInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.deltaYInput.Name = "deltaYInput";
            this.deltaYInput.Size = new System.Drawing.Size(90, 28);
            this.deltaYInput.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.currentHeight, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.label20, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.HeightDownButton, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.HeightZeroButton, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.heightStepSize, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.HeightUpButton, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.label21, 2, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(15, 795);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(339, 147);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // currentHeight
            // 
            this.currentHeight.DecimalPlaces = 3;
            this.currentHeight.Enabled = false;
            this.currentHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.currentHeight.Location = new System.Drawing.Point(229, 51);
            this.currentHeight.Maximum = new decimal(new int[] {
            429,
            0,
            0,
            65536});
            this.currentHeight.Minimum = new decimal(new int[] {
            576,
            0,
            0,
            -2147418112});
            this.currentHeight.Name = "currentHeight";
            this.currentHeight.Size = new System.Drawing.Size(107, 28);
            this.currentHeight.TabIndex = 27;
            this.currentHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentHeight.ValueChanged += new System.EventHandler(this.currentHeight_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(116, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 36);
            this.label20.TabIndex = 14;
            this.label20.Text = "高度步长[mm]";
            // 
            // HeightDownButton
            // 
            this.HeightDownButton.Location = new System.Drawing.Point(3, 99);
            this.HeightDownButton.Name = "HeightDownButton";
            this.HeightDownButton.Size = new System.Drawing.Size(106, 44);
            this.HeightDownButton.TabIndex = 2;
            this.HeightDownButton.Text = "下";
            this.HeightDownButton.UseVisualStyleBackColor = true;
            this.HeightDownButton.Click += new System.EventHandler(this.HeightDownButton_Click);
            // 
            // HeightZeroButton
            // 
            this.HeightZeroButton.Location = new System.Drawing.Point(3, 51);
            this.HeightZeroButton.Name = "HeightZeroButton";
            this.HeightZeroButton.Size = new System.Drawing.Size(106, 42);
            this.HeightZeroButton.TabIndex = 3;
            this.HeightZeroButton.Text = "高度归零";
            this.HeightZeroButton.UseVisualStyleBackColor = true;
            this.HeightZeroButton.Click += new System.EventHandler(this.HeightZeroButton_Click);
            // 
            // heightStepSize
            // 
            this.heightStepSize.DecimalPlaces = 3;
            this.heightStepSize.Location = new System.Drawing.Point(229, 3);
            this.heightStepSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.heightStepSize.Name = "heightStepSize";
            this.heightStepSize.Size = new System.Drawing.Size(107, 28);
            this.heightStepSize.TabIndex = 5;
            this.heightStepSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HeightUpButton
            // 
            this.HeightUpButton.Location = new System.Drawing.Point(3, 3);
            this.HeightUpButton.Name = "HeightUpButton";
            this.HeightUpButton.Size = new System.Drawing.Size(106, 42);
            this.HeightUpButton.TabIndex = 2;
            this.HeightUpButton.Text = "上";
            this.HeightUpButton.UseVisualStyleBackColor = true;
            this.HeightUpButton.Click += new System.EventHandler(this.HeightUpButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(116, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 36);
            this.label21.TabIndex = 14;
            this.label21.Text = "当前高度 [mm]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2117, 1117);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.captureProgressBar);
            this.Controls.Add(this.caputureStartButton);
            this.Controls.Add(this.captureNumberInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveSpeedInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepSizeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeInput)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startX0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX1Input)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startX0InputCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY0InputCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startZ0Input)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaZInputPolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarCoordStepsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaZInputRect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectCoordStepsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaYInput)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightStepSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button goUp;
        private TableLayoutPanel tableLayoutPanel1;
        private Button moveDownButton;
        private Button moveUpButtion;
        private Button moveLeftButton;
        private Button moveRightButton;
        private NumericUpDown moveSpeedInput;
        private Label label1;
        private Label label2;
        private Button returnToZeroButton;
        private NumericUpDown stepSizeInput;
        private NumericUpDown exposureTimeInput;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label positionXLable;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label positionYLable;
        private Label label6;
        private Label label7;
        private Button moveToStartPosition;
        private Button moveToEndPosition;
        private Label label11;
        private Label label12;
        private NumericUpDown captureNumberInput;
        private Button caputureStartButton;
        private Button button3;
        private NumericUpDown startX0Input;
        private NumericUpDown startY0Input;
        private NumericUpDown endY1Input;
        private NumericUpDown endX1Input;
        private PictureBox pictureBox2;



        private ProgressBar captureProgressBar;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label14;
        private Label label13;
        private ListBox commandListBox;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private Label label9;
        private Button addRectCoordButton;
        private NumericUpDown rectCoordStepsInput;
        private Label label10;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label16;
        private Label label17;
        private Button addPolarCoordButton;
        private NumericUpDown polarCoordStepsInput;
        private Label deltaRlable;
        private NumericUpDown thetaInput;
        private Label label19;
        private NumericUpDown deltaRInput;
        private GroupBox groupBox2;
        private Label label15;
        private NumericUpDown deltaXInput;
        private NumericUpDown deltaYInput;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel7;
        private NumericUpDown startX0InputCopy;
        private Label label22;
        private NumericUpDown startY0InputCopy;
        private Button button7;
        private Label label23;
        private Label label24;
        private Button motionRemoveButton;
        private GroupBox groupBox4;
        private ProgressBar commandApplyProgressBar;
        private TableLayoutPanel tableLayoutPanel9;
        private Button HeightDownButton;
        private Button HeightZeroButton;
        private Button HeightUpButton;
        private Label label20;
        private NumericUpDown heightStepSize;
        private Label label21;
        private NumericUpDown currentHeight;
        private NumericUpDown deltaZInputRect;
        private Label label18;
        private NumericUpDown deltaZInputPolar;
        private Label label25;
        private Label label26;
        private NumericUpDown startZ0Input;
    }


}

