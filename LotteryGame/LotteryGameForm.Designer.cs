namespace LotteryGame
{
    partial class LotteryGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Holds the labels for the lottery number labels.
        /// </summary>
        private System.Collections.Generic.List<System.Windows.Forms.Label>
            lotteryNumberLbls = new System.Collections.Generic.List<System.Windows.Forms.Label>();

        /// <summary>
        /// Holds the labels the error labels for a number is not distinct.
        /// </summary>
        private System.Collections.Generic.List<System.Windows.Forms.Label>
            errorLbls = new System.Collections.Generic.List<System.Windows.Forms.Label>();

        
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
            this.gradientGroup1 = new FileSizes.GradientGroup();
            this.numberPickerBtn = new System.Windows.Forms.Button();
            this.errorLbl5 = new System.Windows.Forms.Label();
            this.errorLbl4 = new System.Windows.Forms.Label();
            this.errorLbl3 = new System.Windows.Forms.Label();
            this.errorLbl2 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftLotteryNumber1 = new System.Windows.Forms.Label();
            this.leftLotteryNumber2 = new System.Windows.Forms.Label();
            this.leftLotteryNumber3 = new System.Windows.Forms.Label();
            this.leftLotteryNumber4 = new System.Windows.Forms.Label();
            this.leftLotteryNumber5 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightLotteryNumber1 = new System.Windows.Forms.Label();
            this.rightLotteryNumber2 = new System.Windows.Forms.Label();
            this.rightLotteryNumber3 = new System.Windows.Forms.Label();
            this.rightLotteryNumber4 = new System.Windows.Forms.Label();
            this.rightLotteryNumber5 = new System.Windows.Forms.Label();
            this.WinLoseLbl = new System.Windows.Forms.Label();
            this.lotteryLbl1 = new System.Windows.Forms.Label();
            this.errorLbl1 = new System.Windows.Forms.Label();
            this.lotteryLbl2 = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.lotteryGmaeLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.userNumber5 = new System.Windows.Forms.NumericUpDown();
            this.userNumber4 = new System.Windows.Forms.NumericUpDown();
            this.userNumber3 = new System.Windows.Forms.NumericUpDown();
            this.userNumber2 = new System.Windows.Forms.NumericUpDown();
            this.userNumber1 = new System.Windows.Forms.NumericUpDown();
            this.gradientGroup1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientGroup1
            // 
            this.gradientGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientGroup1.BackColor = System.Drawing.Color.Transparent;
            this.gradientGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradientGroup1.ColorBottom = System.Drawing.Color.Yellow;
            this.gradientGroup1.ColorTop = System.Drawing.Color.Red;
            this.gradientGroup1.Controls.Add(this.numberPickerBtn);
            this.gradientGroup1.Controls.Add(this.errorLbl5);
            this.gradientGroup1.Controls.Add(this.errorLbl4);
            this.gradientGroup1.Controls.Add(this.errorLbl3);
            this.gradientGroup1.Controls.Add(this.errorLbl2);
            this.gradientGroup1.Controls.Add(this.leftPanel);
            this.gradientGroup1.Controls.Add(this.rightPanel);
            this.gradientGroup1.Controls.Add(this.WinLoseLbl);
            this.gradientGroup1.Controls.Add(this.lotteryLbl1);
            this.gradientGroup1.Controls.Add(this.errorLbl1);
            this.gradientGroup1.Controls.Add(this.lotteryLbl2);
            this.gradientGroup1.Controls.Add(this.PlayBtn);
            this.gradientGroup1.Controls.Add(this.lotteryGmaeLbl);
            this.gradientGroup1.Controls.Add(this.InfoLbl);
            this.gradientGroup1.Controls.Add(this.userNumber5);
            this.gradientGroup1.Controls.Add(this.userNumber4);
            this.gradientGroup1.Controls.Add(this.userNumber3);
            this.gradientGroup1.Controls.Add(this.userNumber2);
            this.gradientGroup1.Controls.Add(this.userNumber1);
            this.gradientGroup1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientGroup1.Location = new System.Drawing.Point(-1, -6);
            this.gradientGroup1.Name = "gradientGroup1";
            this.gradientGroup1.Size = new System.Drawing.Size(804, 458);
            this.gradientGroup1.TabIndex = 0;
            this.gradientGroup1.TabStop = false;
            // 
            // numberPickerBtn
            // 
            this.numberPickerBtn.BackColor = System.Drawing.Color.Firebrick;
            this.numberPickerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPickerBtn.Location = new System.Drawing.Point(169, 429);
            this.numberPickerBtn.Name = "numberPickerBtn";
            this.numberPickerBtn.Size = new System.Drawing.Size(119, 23);
            this.numberPickerBtn.TabIndex = 32;
            this.numberPickerBtn.Text = "I\'m Feeling Lucky";
            this.numberPickerBtn.UseVisualStyleBackColor = false;
            // 
            // errorLbl5
            // 
            this.errorLbl5.AutoSize = true;
            this.errorLbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl5.Location = new System.Drawing.Point(547, 271);
            this.errorLbl5.Name = "errorLbl5";
            this.errorLbl5.Size = new System.Drawing.Size(74, 13);
            this.errorLbl5.TabIndex = 31;
            this.errorLbl5.Text = "Not Distinct";
            this.errorLbl5.Visible = false;
            // 
            // errorLbl4
            // 
            this.errorLbl4.AutoSize = true;
            this.errorLbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl4.Location = new System.Drawing.Point(452, 271);
            this.errorLbl4.Name = "errorLbl4";
            this.errorLbl4.Size = new System.Drawing.Size(74, 13);
            this.errorLbl4.TabIndex = 30;
            this.errorLbl4.Text = "Not Distinct";
            this.errorLbl4.Visible = false;
            // 
            // errorLbl3
            // 
            this.errorLbl3.AutoSize = true;
            this.errorLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl3.Location = new System.Drawing.Point(354, 271);
            this.errorLbl3.Name = "errorLbl3";
            this.errorLbl3.Size = new System.Drawing.Size(74, 13);
            this.errorLbl3.TabIndex = 29;
            this.errorLbl3.Text = "Not Distinct";
            this.errorLbl3.Visible = false;
            // 
            // errorLbl2
            // 
            this.errorLbl2.AutoSize = true;
            this.errorLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl2.Location = new System.Drawing.Point(261, 271);
            this.errorLbl2.Name = "errorLbl2";
            this.errorLbl2.Size = new System.Drawing.Size(74, 13);
            this.errorLbl2.TabIndex = 28;
            this.errorLbl2.Text = "Not Distinct";
            this.errorLbl2.Visible = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftLotteryNumber1);
            this.leftPanel.Controls.Add(this.leftLotteryNumber2);
            this.leftPanel.Controls.Add(this.leftLotteryNumber3);
            this.leftPanel.Controls.Add(this.leftLotteryNumber4);
            this.leftPanel.Controls.Add(this.leftLotteryNumber5);
            this.leftPanel.Location = new System.Drawing.Point(42, 68);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(71, 329);
            this.leftPanel.TabIndex = 27;
            this.leftPanel.Visible = false;
            // 
            // leftLotteryNumber1
            // 
            this.leftLotteryNumber1.AutoSize = true;
            this.leftLotteryNumber1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLotteryNumber1.Location = new System.Drawing.Point(3, 0);
            this.leftLotteryNumber1.Name = "leftLotteryNumber1";
            this.leftLotteryNumber1.Size = new System.Drawing.Size(66, 57);
            this.leftLotteryNumber1.TabIndex = 14;
            this.leftLotteryNumber1.Text = "10";
            // 
            // leftLotteryNumber2
            // 
            this.leftLotteryNumber2.AutoSize = true;
            this.leftLotteryNumber2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLotteryNumber2.Location = new System.Drawing.Point(3, 66);
            this.leftLotteryNumber2.Name = "leftLotteryNumber2";
            this.leftLotteryNumber2.Size = new System.Drawing.Size(66, 57);
            this.leftLotteryNumber2.TabIndex = 15;
            this.leftLotteryNumber2.Text = "10";
            // 
            // leftLotteryNumber3
            // 
            this.leftLotteryNumber3.AutoSize = true;
            this.leftLotteryNumber3.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLotteryNumber3.Location = new System.Drawing.Point(3, 133);
            this.leftLotteryNumber3.Name = "leftLotteryNumber3";
            this.leftLotteryNumber3.Size = new System.Drawing.Size(66, 57);
            this.leftLotteryNumber3.TabIndex = 16;
            this.leftLotteryNumber3.Text = "10";
            // 
            // leftLotteryNumber4
            // 
            this.leftLotteryNumber4.AutoSize = true;
            this.leftLotteryNumber4.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLotteryNumber4.Location = new System.Drawing.Point(3, 202);
            this.leftLotteryNumber4.Name = "leftLotteryNumber4";
            this.leftLotteryNumber4.Size = new System.Drawing.Size(66, 57);
            this.leftLotteryNumber4.TabIndex = 17;
            this.leftLotteryNumber4.Text = "10";
            // 
            // leftLotteryNumber5
            // 
            this.leftLotteryNumber5.AutoSize = true;
            this.leftLotteryNumber5.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLotteryNumber5.Location = new System.Drawing.Point(3, 272);
            this.leftLotteryNumber5.Name = "leftLotteryNumber5";
            this.leftLotteryNumber5.Size = new System.Drawing.Size(66, 57);
            this.leftLotteryNumber5.TabIndex = 18;
            this.leftLotteryNumber5.Text = "10";
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightLotteryNumber1);
            this.rightPanel.Controls.Add(this.rightLotteryNumber2);
            this.rightPanel.Controls.Add(this.rightLotteryNumber3);
            this.rightPanel.Controls.Add(this.rightLotteryNumber4);
            this.rightPanel.Controls.Add(this.rightLotteryNumber5);
            this.rightPanel.Location = new System.Drawing.Point(693, 74);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(71, 329);
            this.rightPanel.TabIndex = 26;
            this.rightPanel.Visible = false;
            // 
            // rightLotteryNumber1
            // 
            this.rightLotteryNumber1.AutoSize = true;
            this.rightLotteryNumber1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLotteryNumber1.Location = new System.Drawing.Point(3, 0);
            this.rightLotteryNumber1.Name = "rightLotteryNumber1";
            this.rightLotteryNumber1.Size = new System.Drawing.Size(66, 57);
            this.rightLotteryNumber1.TabIndex = 14;
            this.rightLotteryNumber1.Text = "10";
            // 
            // rightLotteryNumber2
            // 
            this.rightLotteryNumber2.AutoSize = true;
            this.rightLotteryNumber2.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLotteryNumber2.Location = new System.Drawing.Point(3, 66);
            this.rightLotteryNumber2.Name = "rightLotteryNumber2";
            this.rightLotteryNumber2.Size = new System.Drawing.Size(66, 57);
            this.rightLotteryNumber2.TabIndex = 15;
            this.rightLotteryNumber2.Text = "10";
            // 
            // rightLotteryNumber3
            // 
            this.rightLotteryNumber3.AutoSize = true;
            this.rightLotteryNumber3.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLotteryNumber3.Location = new System.Drawing.Point(3, 133);
            this.rightLotteryNumber3.Name = "rightLotteryNumber3";
            this.rightLotteryNumber3.Size = new System.Drawing.Size(66, 57);
            this.rightLotteryNumber3.TabIndex = 16;
            this.rightLotteryNumber3.Text = "10";
            // 
            // rightLotteryNumber4
            // 
            this.rightLotteryNumber4.AutoSize = true;
            this.rightLotteryNumber4.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLotteryNumber4.Location = new System.Drawing.Point(3, 202);
            this.rightLotteryNumber4.Name = "rightLotteryNumber4";
            this.rightLotteryNumber4.Size = new System.Drawing.Size(66, 57);
            this.rightLotteryNumber4.TabIndex = 17;
            this.rightLotteryNumber4.Text = "10";
            // 
            // rightLotteryNumber5
            // 
            this.rightLotteryNumber5.AutoSize = true;
            this.rightLotteryNumber5.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLotteryNumber5.Location = new System.Drawing.Point(3, 272);
            this.rightLotteryNumber5.Name = "rightLotteryNumber5";
            this.rightLotteryNumber5.Size = new System.Drawing.Size(66, 57);
            this.rightLotteryNumber5.TabIndex = 18;
            this.rightLotteryNumber5.Text = "10";
            // 
            // WinLoseLbl
            // 
            this.WinLoseLbl.AutoSize = true;
            this.WinLoseLbl.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLoseLbl.Location = new System.Drawing.Point(308, 168);
            this.WinLoseLbl.Name = "WinLoseLbl";
            this.WinLoseLbl.Size = new System.Drawing.Size(178, 57);
            this.WinLoseLbl.TabIndex = 25;
            this.WinLoseLbl.Text = "You Win!";
            this.WinLoseLbl.Visible = false;
            // 
            // lotteryLbl1
            // 
            this.lotteryLbl1.AutoSize = true;
            this.lotteryLbl1.BackColor = System.Drawing.Color.Transparent;
            this.lotteryLbl1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotteryLbl1.Location = new System.Drawing.Point(6, 31);
            this.lotteryLbl1.Name = "lotteryLbl1";
            this.lotteryLbl1.Size = new System.Drawing.Size(163, 34);
            this.lotteryLbl1.TabIndex = 19;
            this.lotteryLbl1.Text = "Lottery Numbers";
            this.lotteryLbl1.Visible = false;
            // 
            // errorLbl1
            // 
            this.errorLbl1.AutoSize = true;
            this.errorLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl1.Location = new System.Drawing.Point(170, 271);
            this.errorLbl1.Name = "errorLbl1";
            this.errorLbl1.Size = new System.Drawing.Size(74, 13);
            this.errorLbl1.TabIndex = 9;
            this.errorLbl1.Text = "Not Distinct";
            this.errorLbl1.Visible = false;
            // 
            // lotteryLbl2
            // 
            this.lotteryLbl2.AutoSize = true;
            this.lotteryLbl2.BackColor = System.Drawing.Color.Transparent;
            this.lotteryLbl2.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotteryLbl2.Location = new System.Drawing.Point(641, 31);
            this.lotteryLbl2.Name = "lotteryLbl2";
            this.lotteryLbl2.Size = new System.Drawing.Size(163, 34);
            this.lotteryLbl2.TabIndex = 8;
            this.lotteryLbl2.Text = "Lottery Numbers";
            this.lotteryLbl2.Visible = false;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Crimson;
            this.PlayBtn.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.Location = new System.Drawing.Point(166, 297);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(455, 127);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            // 
            // lotteryGmaeLbl
            // 
            this.lotteryGmaeLbl.AutoSize = true;
            this.lotteryGmaeLbl.BackColor = System.Drawing.Color.Transparent;
            this.lotteryGmaeLbl.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotteryGmaeLbl.Location = new System.Drawing.Point(143, 65);
            this.lotteryGmaeLbl.Name = "lotteryGmaeLbl";
            this.lotteryGmaeLbl.Size = new System.Drawing.Size(515, 114);
            this.lotteryGmaeLbl.TabIndex = 6;
            this.lotteryGmaeLbl.Text = "LOTTERY GAME";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.InfoLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.Location = new System.Drawing.Point(117, 179);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(576, 18);
            this.InfoLbl.TabIndex = 5;
            this.InfoLbl.Text = "Select or Enter Five Distinct Numbers In The Range Of One Through Forty";
            this.InfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNumber5
            // 
            this.userNumber5.BackColor = System.Drawing.Color.Crimson;
            this.userNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber5.Location = new System.Drawing.Point(546, 228);
            this.userNumber5.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.userNumber5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userNumber5.Name = "userNumber5";
            this.userNumber5.Size = new System.Drawing.Size(75, 40);
            this.userNumber5.TabIndex = 4;
            this.userNumber5.Tag = 4;
            this.userNumber5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumber5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // userNumber4
            // 
            this.userNumber4.BackColor = System.Drawing.Color.Yellow;
            this.userNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber4.Location = new System.Drawing.Point(451, 228);
            this.userNumber4.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.userNumber4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userNumber4.Name = "userNumber4";
            this.userNumber4.Size = new System.Drawing.Size(75, 40);
            this.userNumber4.TabIndex = 3;
            this.userNumber4.Tag = 3;
            this.userNumber4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumber4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // userNumber3
            // 
            this.userNumber3.BackColor = System.Drawing.Color.Crimson;
            this.userNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber3.Location = new System.Drawing.Point(357, 228);
            this.userNumber3.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.userNumber3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userNumber3.Name = "userNumber3";
            this.userNumber3.Size = new System.Drawing.Size(75, 40);
            this.userNumber3.TabIndex = 2;
            this.userNumber3.Tag = 2;
            this.userNumber3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumber3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // userNumber2
            // 
            this.userNumber2.BackColor = System.Drawing.Color.Yellow;
            this.userNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber2.Location = new System.Drawing.Point(260, 228);
            this.userNumber2.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.userNumber2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userNumber2.Name = "userNumber2";
            this.userNumber2.Size = new System.Drawing.Size(75, 40);
            this.userNumber2.TabIndex = 1;
            this.userNumber2.Tag = 1;
            this.userNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumber2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // userNumber1
            // 
            this.userNumber1.BackColor = System.Drawing.Color.Crimson;
            this.userNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumber1.Location = new System.Drawing.Point(169, 228);
            this.userNumber1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.userNumber1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userNumber1.Name = "userNumber1";
            this.userNumber1.Size = new System.Drawing.Size(75, 40);
            this.userNumber1.TabIndex = 0;
            this.userNumber1.Tag = 0;
            this.userNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumber1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LotteryGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gradientGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LotteryGameForm";
            this.ShowIcon = false;
            this.Text = "Lottery Game";
            this.gradientGroup1.ResumeLayout(false);
            this.gradientGroup1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNumber1)).EndInit();
            this.ResumeLayout(false);

        }

        private void fillArrays()
        {
            errorLbls.Add(errorLbl1);
            errorLbls.Add(errorLbl2);
            errorLbls.Add(errorLbl3);
            errorLbls.Add(errorLbl4);
            errorLbls.Add(errorLbl5);

            lotteryNumberLbls.Add(leftLotteryNumber1);
            lotteryNumberLbls.Add(leftLotteryNumber2);
            lotteryNumberLbls.Add(leftLotteryNumber3);
            lotteryNumberLbls.Add(leftLotteryNumber4);
            lotteryNumberLbls.Add(leftLotteryNumber5);
            lotteryNumberLbls.Add(rightLotteryNumber1);
            lotteryNumberLbls.Add(rightLotteryNumber2);
            lotteryNumberLbls.Add(rightLotteryNumber3);
            lotteryNumberLbls.Add(rightLotteryNumber4);
            lotteryNumberLbls.Add(rightLotteryNumber5);
        }

        #endregion

        private FileSizes.GradientGroup gradientGroup1;
        private System.Windows.Forms.NumericUpDown userNumber1;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label lotteryGmaeLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.NumericUpDown userNumber5;
        private System.Windows.Forms.NumericUpDown userNumber4;
        private System.Windows.Forms.NumericUpDown userNumber3;
        private System.Windows.Forms.NumericUpDown userNumber2;
        private System.Windows.Forms.Label errorLbl1;
        private System.Windows.Forms.Label lotteryLbl2;
        private System.Windows.Forms.Label WinLoseLbl;
        private System.Windows.Forms.Label lotteryLbl1;
        private System.Windows.Forms.Label rightLotteryNumber5;
        private System.Windows.Forms.Label rightLotteryNumber4;
        private System.Windows.Forms.Label rightLotteryNumber3;
        private System.Windows.Forms.Label rightLotteryNumber2;
        private System.Windows.Forms.Label rightLotteryNumber1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label leftLotteryNumber1;
        private System.Windows.Forms.Label leftLotteryNumber2;
        private System.Windows.Forms.Label leftLotteryNumber3;
        private System.Windows.Forms.Label leftLotteryNumber4;
        private System.Windows.Forms.Label leftLotteryNumber5;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label errorLbl5;
        private System.Windows.Forms.Label errorLbl4;
        private System.Windows.Forms.Label errorLbl3;
        private System.Windows.Forms.Label errorLbl2;
        private System.Windows.Forms.Button numberPickerBtn;
    }
}

