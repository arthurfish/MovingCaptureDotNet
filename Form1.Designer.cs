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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.startX0InputCopy = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.startY0InputCopy = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.motionRemoveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addRectCoordButton = new System.Windows.Forms.Button();
            this.rectCoordStepsInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.deltaXInput = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.deltaYInput = new System.Windows.Forms.NumericUpDown();
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
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polarCoordStepsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectCoordStepsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaYInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1444, 805);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 840);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 198);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(152, 134);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(146, 62);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButtion
            // 
            this.moveUpButtion.Location = new System.Drawing.Point(152, 2);
            this.moveUpButtion.Margin = new System.Windows.Forms.Padding(2);
            this.moveUpButtion.Name = "moveUpButtion";
            this.moveUpButtion.Size = new System.Drawing.Size(146, 61);
            this.moveUpButtion.TabIndex = 2;
            this.moveUpButtion.Text = "Up";
            this.moveUpButtion.UseVisualStyleBackColor = true;
            this.moveUpButtion.Click += new System.EventHandler(this.moveUpButtion_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(2, 68);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(146, 61);
            this.moveLeftButton.TabIndex = 2;
            this.moveLeftButton.Text = "Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(302, 68);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(146, 61);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "Right";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // returnToZeroButton
            // 
            this.returnToZeroButton.Location = new System.Drawing.Point(152, 68);
            this.returnToZeroButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnToZeroButton.Name = "returnToZeroButton";
            this.returnToZeroButton.Size = new System.Drawing.Size(146, 61);
            this.returnToZeroButton.TabIndex = 3;
            this.returnToZeroButton.Text = "Zero";
            this.returnToZeroButton.UseVisualStyleBackColor = true;
            // 
            // moveSpeedInput
            // 
            this.moveSpeedInput.Location = new System.Drawing.Point(315, 2);
            this.moveSpeedInput.Margin = new System.Windows.Forms.Padding(2);
            this.moveSpeedInput.Name = "moveSpeedInput";
            this.moveSpeedInput.Size = new System.Drawing.Size(153, 35);
            this.moveSpeedInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Velocity(mm/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step Size(mm)";
            // 
            // stepSizeInput
            // 
            this.stepSizeInput.Location = new System.Drawing.Point(315, 109);
            this.stepSizeInput.Margin = new System.Windows.Forms.Padding(2);
            this.stepSizeInput.Name = "stepSizeInput";
            this.stepSizeInput.Size = new System.Drawing.Size(153, 35);
            this.stepSizeInput.TabIndex = 5;
            // 
            // exposureTimeInput
            // 
            this.exposureTimeInput.Location = new System.Drawing.Point(315, 216);
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
            this.exposureTimeInput.Size = new System.Drawing.Size(153, 35);
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
            this.label3.Location = new System.Drawing.Point(2, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exposure Time(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position X(mm): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position Y(mm): ";
            // 
            // positionXLable
            // 
            this.positionXLable.AutoSize = true;
            this.positionXLable.Location = new System.Drawing.Point(334, 0);
            this.positionXLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionXLable.Name = "positionXLable";
            this.positionXLable.Size = new System.Drawing.Size(22, 24);
            this.positionXLable.TabIndex = 7;
            this.positionXLable.Text = "0";
            this.positionXLable.Click += new System.EventHandler(this.positionXLable_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.moveSpeedInput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.stepSizeInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.exposureTimeInput, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(490, 842);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 321);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.positionXLable, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.positionYLable, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(965, 841);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 74);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // positionYLable
            // 
            this.positionYLable.AutoSize = true;
            this.positionYLable.Location = new System.Drawing.Point(334, 37);
            this.positionYLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionYLable.Name = "positionYLable";
            this.positionYLable.Size = new System.Drawing.Size(22, 24);
            this.positionYLable.TabIndex = 7;
            this.positionYLable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "x(mm)";
            // 
            // moveToStartPosition
            // 
            this.moveToStartPosition.Location = new System.Drawing.Point(374, 45);
            this.moveToStartPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToStartPosition.Name = "moveToStartPosition";
            this.moveToStartPosition.Size = new System.Drawing.Size(121, 35);
            this.moveToStartPosition.TabIndex = 4;
            this.moveToStartPosition.Text = "Go";
            this.moveToStartPosition.UseVisualStyleBackColor = true;
            this.moveToStartPosition.Click += new System.EventHandler(this.moveToStartPosition_Click_1);
            // 
            // moveToEndPosition
            // 
            this.moveToEndPosition.Location = new System.Drawing.Point(374, 88);
            this.moveToEndPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToEndPosition.Name = "moveToEndPosition";
            this.moveToEndPosition.Size = new System.Drawing.Size(121, 35);
            this.moveToEndPosition.TabIndex = 13;
            this.moveToEndPosition.Text = "Go";
            this.moveToEndPosition.UseVisualStyleBackColor = true;
            this.moveToEndPosition.Click += new System.EventHandler(this.moveToEndPosition_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "End";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(968, 1089);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Capture Number: ";
            // 
            // captureNumberInput
            // 
            this.captureNumberInput.Location = new System.Drawing.Point(1258, 1080);
            this.captureNumberInput.Margin = new System.Windows.Forms.Padding(2);
            this.captureNumberInput.Name = "captureNumberInput";
            this.captureNumberInput.Size = new System.Drawing.Size(79, 35);
            this.captureNumberInput.TabIndex = 7;
            // 
            // caputureStartButton
            // 
            this.caputureStartButton.Location = new System.Drawing.Point(1358, 1080);
            this.caputureStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.caputureStartButton.Name = "caputureStartButton";
            this.caputureStartButton.Size = new System.Drawing.Size(104, 42);
            this.caputureStartButton.TabIndex = 20;
            this.caputureStartButton.Text = "Caputre Start";
            this.caputureStartButton.UseVisualStyleBackColor = true;
            this.caputureStartButton.Click += new System.EventHandler(this.caputureStartButton_Click);
            // 
            // startX0Input
            // 
            this.startX0Input.DecimalPlaces = 3;
            this.startX0Input.Location = new System.Drawing.Point(126, 45);
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
            this.startX0Input.Size = new System.Drawing.Size(120, 35);
            this.startX0Input.TabIndex = 7;
            // 
            // startY0Input
            // 
            this.startY0Input.DecimalPlaces = 3;
            this.startY0Input.Location = new System.Drawing.Point(250, 45);
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
            this.startY0Input.Size = new System.Drawing.Size(120, 35);
            this.startY0Input.TabIndex = 21;
            // 
            // endY1Input
            // 
            this.endY1Input.DecimalPlaces = 3;
            this.endY1Input.Location = new System.Drawing.Point(250, 88);
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
            this.endY1Input.Size = new System.Drawing.Size(120, 35);
            this.endY1Input.TabIndex = 21;
            // 
            // endX1Input
            // 
            this.endX1Input.DecimalPlaces = 3;
            this.endX1Input.Location = new System.Drawing.Point(126, 88);
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
            this.endX1Input.Size = new System.Drawing.Size(120, 35);
            this.endX1Input.TabIndex = 7;
            // 
            // captureProgressBar
            // 
            this.captureProgressBar.Location = new System.Drawing.Point(965, 1137);
            this.captureProgressBar.Name = "captureProgressBar";
            this.captureProgressBar.Size = new System.Drawing.Size(496, 26);
            this.captureProgressBar.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(965, 936);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(499, 131);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 24);
            this.label14.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "y(mm)";
            // 
            // commandListBox
            // 
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 24;
            this.commandListBox.Location = new System.Drawing.Point(6, 34);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.ScrollAlwaysVisible = true;
            this.commandListBox.Size = new System.Drawing.Size(320, 772);
            this.commandListBox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.motionRemoveButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.commandListBox);
            this.groupBox1.Location = new System.Drawing.Point(1486, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 805);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move Commands";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Location = new System.Drawing.Point(332, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 137);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start Position";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.startX0InputCopy, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.startY0InputCopy, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(18, 34);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(366, 79);
            this.tableLayoutPanel7.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(2, 0);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 24);
            this.label23.TabIndex = 11;
            this.label23.Text = "x(mm)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(2, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 24);
            this.label24.TabIndex = 11;
            this.label24.Text = "y(mm)";
            // 
            // startX0InputCopy
            // 
            this.startX0InputCopy.DecimalPlaces = 3;
            this.startX0InputCopy.Location = new System.Drawing.Point(124, 2);
            this.startX0InputCopy.Margin = new System.Windows.Forms.Padding(2);
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
            this.startX0InputCopy.Size = new System.Drawing.Size(118, 35);
            this.startX0InputCopy.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(246, 39);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 24);
            this.label22.TabIndex = 17;
            // 
            // startY0InputCopy
            // 
            this.startY0InputCopy.DecimalPlaces = 3;
            this.startY0InputCopy.Location = new System.Drawing.Point(124, 41);
            this.startY0InputCopy.Margin = new System.Windows.Forms.Padding(2);
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
            this.startY0InputCopy.Size = new System.Drawing.Size(118, 35);
            this.startY0InputCopy.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(246, 2);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 35);
            this.button7.TabIndex = 4;
            this.button7.Text = "Go";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.moveToStartPosition_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 580);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(496, 36);
            this.button5.TabIndex = 31;
            this.button5.Text = "Start !";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // motionRemoveButton
            // 
            this.motionRemoveButton.Location = new System.Drawing.Point(332, 527);
            this.motionRemoveButton.Name = "motionRemoveButton";
            this.motionRemoveButton.Size = new System.Drawing.Size(496, 36);
            this.motionRemoveButton.TabIndex = 30;
            this.motionRemoveButton.Text = "Remove";
            this.motionRemoveButton.UseVisualStyleBackColor = true;
            this.motionRemoveButton.Click += new System.EventHandler(this.motionRemoveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Location = new System.Drawing.Point(332, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 150);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Polar Coordinate Vector";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label16, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.addPolarCoordButton, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.polarCoordStepsInput, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.deltaRlable, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.thetaInput, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label19, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.deltaRInput, 2, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 34);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(463, 100);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 24);
            this.label16.TabIndex = 29;
            this.label16.Text = "Action";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "θ (mm)";
            // 
            // addPolarCoordButton
            // 
            this.addPolarCoordButton.Location = new System.Drawing.Point(329, 53);
            this.addPolarCoordButton.Name = "addPolarCoordButton";
            this.addPolarCoordButton.Size = new System.Drawing.Size(120, 36);
            this.addPolarCoordButton.TabIndex = 27;
            this.addPolarCoordButton.Text = "Add";
            this.addPolarCoordButton.UseVisualStyleBackColor = true;
            this.addPolarCoordButton.Click += new System.EventHandler(this.addPolarCoordButton_Click);
            // 
            // polarCoordStepsInput
            // 
            this.polarCoordStepsInput.Location = new System.Drawing.Point(329, 3);
            this.polarCoordStepsInput.Name = "polarCoordStepsInput";
            this.polarCoordStepsInput.Size = new System.Drawing.Size(120, 35);
            this.polarCoordStepsInput.TabIndex = 27;
            // 
            // deltaRlable
            // 
            this.deltaRlable.AutoSize = true;
            this.deltaRlable.Location = new System.Drawing.Point(3, 50);
            this.deltaRlable.Name = "deltaRlable";
            this.deltaRlable.Size = new System.Drawing.Size(106, 24);
            this.deltaRlable.TabIndex = 1;
            this.deltaRlable.Text = "Δr (mm)";
            // 
            // thetaInput
            // 
            this.thetaInput.Location = new System.Drawing.Point(115, 3);
            this.thetaInput.Name = "thetaInput";
            this.thetaInput.Size = new System.Drawing.Size(120, 35);
            this.thetaInput.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(241, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 24);
            this.label19.TabIndex = 27;
            this.label19.Text = "Steps";
            // 
            // deltaRInput
            // 
            this.deltaRInput.Location = new System.Drawing.Point(115, 53);
            this.deltaRInput.Name = "deltaRInput";
            this.deltaRInput.Size = new System.Drawing.Size(120, 35);
            this.deltaRInput.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(332, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 150);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rectangular Coordinate Vector";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label15, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.addRectCoordButton, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.rectCoordStepsInput, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.deltaXInput, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.deltaYInput, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(18, 34);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(463, 100);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Action";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Δx (mm)";
            // 
            // addRectCoordButton
            // 
            this.addRectCoordButton.Location = new System.Drawing.Point(329, 53);
            this.addRectCoordButton.Name = "addRectCoordButton";
            this.addRectCoordButton.Size = new System.Drawing.Size(120, 36);
            this.addRectCoordButton.TabIndex = 27;
            this.addRectCoordButton.Text = "Add";
            this.addRectCoordButton.UseVisualStyleBackColor = true;
            this.addRectCoordButton.Click += new System.EventHandler(this.addRectCoordButton_Click);
            // 
            // rectCoordStepsInput
            // 
            this.rectCoordStepsInput.Location = new System.Drawing.Point(329, 3);
            this.rectCoordStepsInput.Name = "rectCoordStepsInput";
            this.rectCoordStepsInput.Size = new System.Drawing.Size(120, 35);
            this.rectCoordStepsInput.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Δy (mm)";
            // 
            // deltaXInput
            // 
            this.deltaXInput.Location = new System.Drawing.Point(115, 3);
            this.deltaXInput.Name = "deltaXInput";
            this.deltaXInput.Size = new System.Drawing.Size(120, 35);
            this.deltaXInput.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Steps";
            // 
            // deltaYInput
            // 
            this.deltaYInput.Location = new System.Drawing.Point(115, 53);
            this.deltaYInput.Name = "deltaYInput";
            this.deltaYInput.Size = new System.Drawing.Size(120, 35);
            this.deltaYInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2467, 1399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.captureProgressBar);
            this.Controls.Add(this.caputureStartButton);
            this.Controls.Add(this.captureNumberInput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polarCoordStepsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaRInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectCoordStepsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaYInput)).EndInit();
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

        private PositioningPlatform positioningPlatform;
        private Camera camera;
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
    }


}

