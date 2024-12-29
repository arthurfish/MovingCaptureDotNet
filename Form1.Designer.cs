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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1324, 704);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 735);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 173);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(140, 116);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(134, 54);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "Down";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButtion
            // 
            this.moveUpButtion.Location = new System.Drawing.Point(140, 2);
            this.moveUpButtion.Margin = new System.Windows.Forms.Padding(2);
            this.moveUpButtion.Name = "moveUpButtion";
            this.moveUpButtion.Size = new System.Drawing.Size(134, 53);
            this.moveUpButtion.TabIndex = 2;
            this.moveUpButtion.Text = "Up";
            this.moveUpButtion.UseVisualStyleBackColor = true;
            this.moveUpButtion.Click += new System.EventHandler(this.moveUpButtion_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(2, 59);
            this.moveLeftButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(134, 53);
            this.moveLeftButton.TabIndex = 2;
            this.moveLeftButton.Text = "Left";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(278, 59);
            this.moveRightButton.Margin = new System.Windows.Forms.Padding(2);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(134, 53);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.Text = "Right";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // returnToZeroButton
            // 
            this.returnToZeroButton.Location = new System.Drawing.Point(140, 59);
            this.returnToZeroButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnToZeroButton.Name = "returnToZeroButton";
            this.returnToZeroButton.Size = new System.Drawing.Size(134, 53);
            this.returnToZeroButton.TabIndex = 3;
            this.returnToZeroButton.Text = "Zero";
            this.returnToZeroButton.UseVisualStyleBackColor = true;
            // 
            // moveSpeedInput
            // 
            this.moveSpeedInput.Location = new System.Drawing.Point(289, 2);
            this.moveSpeedInput.Margin = new System.Windows.Forms.Padding(2);
            this.moveSpeedInput.Name = "moveSpeedInput";
            this.moveSpeedInput.Size = new System.Drawing.Size(140, 31);
            this.moveSpeedInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Velocity(mm/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Step Size(mm)";
            // 
            // stepSizeInput
            // 
            this.stepSizeInput.Location = new System.Drawing.Point(289, 95);
            this.stepSizeInput.Margin = new System.Windows.Forms.Padding(2);
            this.stepSizeInput.Name = "stepSizeInput";
            this.stepSizeInput.Size = new System.Drawing.Size(140, 31);
            this.stepSizeInput.TabIndex = 5;
            // 
            // exposureTimeInput
            // 
            this.exposureTimeInput.Location = new System.Drawing.Point(289, 188);
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
            this.exposureTimeInput.Size = new System.Drawing.Size(140, 31);
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
            this.label3.Location = new System.Drawing.Point(2, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exposure Time(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position X(mm): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position Y(mm): ";
            // 
            // positionXLable
            // 
            this.positionXLable.AutoSize = true;
            this.positionXLable.Location = new System.Drawing.Point(306, 0);
            this.positionXLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionXLable.Name = "positionXLable";
            this.positionXLable.Size = new System.Drawing.Size(21, 21);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(449, 737);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(431, 281);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(885, 736);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(457, 65);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // positionYLable
            // 
            this.positionYLable.AutoSize = true;
            this.positionYLable.Location = new System.Drawing.Point(306, 32);
            this.positionYLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.positionYLable.Name = "positionYLable";
            this.positionYLable.Size = new System.Drawing.Size(21, 21);
            this.positionYLable.TabIndex = 7;
            this.positionYLable.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "x(mm)";
            // 
            // moveToStartPosition
            // 
            this.moveToStartPosition.Location = new System.Drawing.Point(344, 40);
            this.moveToStartPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToStartPosition.Name = "moveToStartPosition";
            this.moveToStartPosition.Size = new System.Drawing.Size(111, 31);
            this.moveToStartPosition.TabIndex = 4;
            this.moveToStartPosition.Text = "Go";
            this.moveToStartPosition.UseVisualStyleBackColor = true;
            this.moveToStartPosition.Click += new System.EventHandler(this.moveToStartPosition_Click_1);
            // 
            // moveToEndPosition
            // 
            this.moveToEndPosition.Location = new System.Drawing.Point(344, 78);
            this.moveToEndPosition.Margin = new System.Windows.Forms.Padding(2);
            this.moveToEndPosition.Name = "moveToEndPosition";
            this.moveToEndPosition.Size = new System.Drawing.Size(111, 31);
            this.moveToEndPosition.TabIndex = 13;
            this.moveToEndPosition.Text = "Go";
            this.moveToEndPosition.UseVisualStyleBackColor = true;
            this.moveToEndPosition.Click += new System.EventHandler(this.moveToEndPosition_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "End";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(887, 953);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Capture Number: ";
            // 
            // captureNumberInput
            // 
            this.captureNumberInput.Location = new System.Drawing.Point(1153, 945);
            this.captureNumberInput.Margin = new System.Windows.Forms.Padding(2);
            this.captureNumberInput.Name = "captureNumberInput";
            this.captureNumberInput.Size = new System.Drawing.Size(72, 31);
            this.captureNumberInput.TabIndex = 7;
            // 
            // caputureStartButton
            // 
            this.caputureStartButton.Location = new System.Drawing.Point(1245, 945);
            this.caputureStartButton.Margin = new System.Windows.Forms.Padding(2);
            this.caputureStartButton.Name = "caputureStartButton";
            this.caputureStartButton.Size = new System.Drawing.Size(95, 37);
            this.caputureStartButton.TabIndex = 20;
            this.caputureStartButton.Text = "Caputre Start";
            this.caputureStartButton.UseVisualStyleBackColor = true;
            this.caputureStartButton.Click += new System.EventHandler(this.caputureStartButton_Click);
            // 
            // startX0Input
            // 
            this.startX0Input.DecimalPlaces = 3;
            this.startX0Input.Location = new System.Drawing.Point(116, 40);
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
            this.startX0Input.Size = new System.Drawing.Size(110, 31);
            this.startX0Input.TabIndex = 7;
            // 
            // startY0Input
            // 
            this.startY0Input.DecimalPlaces = 3;
            this.startY0Input.Location = new System.Drawing.Point(230, 40);
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
            this.startY0Input.Size = new System.Drawing.Size(110, 31);
            this.startY0Input.TabIndex = 21;
            // 
            // endY1Input
            // 
            this.endY1Input.DecimalPlaces = 3;
            this.endY1Input.Location = new System.Drawing.Point(230, 78);
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
            this.endY1Input.Size = new System.Drawing.Size(110, 31);
            this.endY1Input.TabIndex = 21;
            // 
            // endX1Input
            // 
            this.endX1Input.DecimalPlaces = 3;
            this.endX1Input.Location = new System.Drawing.Point(116, 78);
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
            this.endX1Input.Size = new System.Drawing.Size(110, 31);
            this.endX1Input.TabIndex = 7;
            // 
            // captureProgressBar
            // 
            this.captureProgressBar.Location = new System.Drawing.Point(885, 995);
            this.captureProgressBar.Name = "captureProgressBar";
            this.captureProgressBar.Size = new System.Drawing.Size(455, 23);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(885, 819);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(457, 115);
            this.tableLayoutPanel4.TabIndex = 23;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "y(mm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 1382);
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
    }


}

