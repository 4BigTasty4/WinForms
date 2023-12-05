namespace WinFormsApp
{
    partial class Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            panel1 = new Panel();
            resultTextBox = new TextBox();
            calcName = new Label();
            panel2 = new Panel();
            subtractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            additionButton = new Button();
            nineButton = new Button();
            equalsButton = new Button();
            button3 = new Button();
            commaButton = new Button();
            eightButton = new Button();
            fiveButton = new Button();
            twoButton = new Button();
            sevenButton = new Button();
            fourButton = new Button();
            oneButton = new Button();
            sixButton = new Button();
            threeButton = new Button();
            clearButton = new Button();
            button2 = new Button();
            button1 = new Button();
            zeroButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(resultTextBox);
            panel1.Controls.Add(calcName);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 452);
            panel1.TabIndex = 0;
            // 
            // resultTextBox
            // 
            resultTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            resultTextBox.BackColor = SystemColors.ControlText;
            resultTextBox.BorderStyle = BorderStyle.None;
            resultTextBox.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.ForeColor = Color.Transparent;
            resultTextBox.Location = new Point(13, 42);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(263, 40);
            resultTextBox.TabIndex = 1;
            resultTextBox.Text = "0";
            resultTextBox.TextAlign = HorizontalAlignment.Right;
            resultTextBox.Click += resultTextBox_Click;
            // 
            // calcName
            // 
            calcName.Location = new Point(12, 30);
            calcName.Name = "calcName";
            calcName.Size = new Size(262, 41);
            calcName.TabIndex = 1;
            calcName.Text = "label1";
            // 
            // panel2
            // 
            panel2.Controls.Add(subtractionButton);
            panel2.Controls.Add(multiplicationButton);
            panel2.Controls.Add(divisionButton);
            panel2.Controls.Add(additionButton);
            panel2.Controls.Add(nineButton);
            panel2.Controls.Add(equalsButton);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(commaButton);
            panel2.Controls.Add(eightButton);
            panel2.Controls.Add(fiveButton);
            panel2.Controls.Add(twoButton);
            panel2.Controls.Add(sevenButton);
            panel2.Controls.Add(fourButton);
            panel2.Controls.Add(oneButton);
            panel2.Controls.Add(sixButton);
            panel2.Controls.Add(threeButton);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(zeroButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 364);
            panel2.TabIndex = 0;
            panel2.Click += divisionButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.BackColor = Color.Orange;
            subtractionButton.Cursor = Cursors.Hand;
            subtractionButton.FlatAppearance.BorderSize = 0;
            subtractionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            subtractionButton.FlatStyle = FlatStyle.Flat;
            subtractionButton.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            subtractionButton.ForeColor = Color.White;
            subtractionButton.Location = new Point(213, 180);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(61, 53);
            subtractionButton.TabIndex = 16;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = false;
            subtractionButton.Click += divisionButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.BackColor = Color.Orange;
            multiplicationButton.Cursor = Cursors.Hand;
            multiplicationButton.FlatAppearance.BorderSize = 0;
            multiplicationButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            multiplicationButton.FlatStyle = FlatStyle.Flat;
            multiplicationButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.ForeColor = Color.White;
            multiplicationButton.Location = new Point(213, 121);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(61, 53);
            multiplicationButton.TabIndex = 15;
            multiplicationButton.Text = "x";
            multiplicationButton.UseVisualStyleBackColor = false;
            multiplicationButton.Click += divisionButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.BackColor = Color.Orange;
            divisionButton.Cursor = Cursors.Hand;
            divisionButton.FlatAppearance.BorderSize = 0;
            divisionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            divisionButton.FlatStyle = FlatStyle.Flat;
            divisionButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            divisionButton.ForeColor = Color.White;
            divisionButton.Location = new Point(213, 63);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(61, 53);
            divisionButton.TabIndex = 14;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += divisionButton_Click;
            // 
            // additionButton
            // 
            additionButton.BackColor = Color.Orange;
            additionButton.Cursor = Cursors.Hand;
            additionButton.FlatAppearance.BorderSize = 0;
            additionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            additionButton.FlatStyle = FlatStyle.Flat;
            additionButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            additionButton.ForeColor = Color.White;
            additionButton.Location = new Point(213, 239);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(61, 53);
            additionButton.TabIndex = 13;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = false;
            additionButton.Click += divisionButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = Color.FromArgb(64, 64, 64);
            nineButton.Cursor = Cursors.Hand;
            nineButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            nineButton.ForeColor = Color.White;
            nineButton.Location = new Point(147, 121);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(61, 53);
            nineButton.TabIndex = 12;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += resultTextBox_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.Orange;
            equalsButton.Cursor = Cursors.Hand;
            equalsButton.FlatAppearance.BorderSize = 0;
            equalsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            equalsButton.FlatStyle = FlatStyle.Flat;
            equalsButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            equalsButton.ForeColor = Color.White;
            equalsButton.Location = new Point(213, 299);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(61, 53);
            equalsButton.TabIndex = 11;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(146, 299);
            button3.Name = "button3";
            button3.Size = new Size(61, 53);
            button3.TabIndex = 10;
            button3.Text = ",";
            button3.UseVisualStyleBackColor = false;
            button3.Click += commaButton_Click;
            // 
            // commaButton
            // 
            commaButton.BackColor = Color.FromArgb(64, 64, 64);
            commaButton.Cursor = Cursors.Hand;
            commaButton.FlatAppearance.BorderSize = 0;
            commaButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            commaButton.FlatStyle = FlatStyle.Flat;
            commaButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            commaButton.ForeColor = Color.White;
            commaButton.Location = new Point(146, 298);
            commaButton.Name = "commaButton";
            commaButton.Size = new Size(61, 53);
            commaButton.TabIndex = 10;
            commaButton.Text = ",";
            commaButton.UseVisualStyleBackColor = false;
            commaButton.Click += commaButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = Color.FromArgb(64, 64, 64);
            eightButton.Cursor = Cursors.Hand;
            eightButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            eightButton.ForeColor = Color.White;
            eightButton.Location = new Point(80, 121);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(61, 53);
            eightButton.TabIndex = 9;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += resultTextBox_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = Color.FromArgb(64, 64, 64);
            fiveButton.Cursor = Cursors.Hand;
            fiveButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            fiveButton.ForeColor = Color.White;
            fiveButton.Location = new Point(80, 180);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(61, 53);
            fiveButton.TabIndex = 8;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += resultTextBox_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = Color.FromArgb(64, 64, 64);
            twoButton.Cursor = Cursors.Hand;
            twoButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            twoButton.ForeColor = Color.White;
            twoButton.Location = new Point(80, 239);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(61, 53);
            twoButton.TabIndex = 7;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += resultTextBox_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = Color.FromArgb(64, 64, 64);
            sevenButton.Cursor = Cursors.Hand;
            sevenButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            sevenButton.ForeColor = Color.White;
            sevenButton.Location = new Point(12, 121);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(61, 53);
            sevenButton.TabIndex = 6;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += resultTextBox_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = Color.FromArgb(64, 64, 64);
            fourButton.Cursor = Cursors.Hand;
            fourButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            fourButton.ForeColor = Color.White;
            fourButton.Location = new Point(13, 180);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(61, 53);
            fourButton.TabIndex = 5;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += resultTextBox_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = Color.FromArgb(64, 64, 64);
            oneButton.Cursor = Cursors.Hand;
            oneButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            oneButton.ForeColor = Color.White;
            oneButton.Location = new Point(13, 239);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(61, 53);
            oneButton.TabIndex = 4;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += resultTextBox_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = Color.FromArgb(64, 64, 64);
            sixButton.Cursor = Cursors.Hand;
            sixButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            sixButton.ForeColor = Color.White;
            sixButton.Location = new Point(147, 180);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(61, 53);
            sixButton.TabIndex = 3;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += resultTextBox_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = Color.FromArgb(64, 64, 64);
            threeButton.Cursor = Cursors.Hand;
            threeButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            threeButton.ForeColor = Color.White;
            threeButton.Location = new Point(147, 239);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(61, 53);
            threeButton.TabIndex = 2;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += resultTextBox_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ActiveBorder;
            clearButton.BackgroundImageLayout = ImageLayout.Center;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ActiveCaptionText;
            clearButton.Location = new Point(12, 63);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(196, 53);
            clearButton.TabIndex = 1;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 299);
            button2.Name = "button2";
            button2.Size = new Size(128, 53);
            button2.TabIndex = 0;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = false;
            button2.Click += resultTextBox_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 299);
            button1.Name = "button1";
            button1.Size = new Size(128, 53);
            button1.TabIndex = 0;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += resultTextBox_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = Color.FromArgb(64, 64, 64);
            zeroButton.Cursor = Cursors.Hand;
            zeroButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            zeroButton.ForeColor = Color.White;
            zeroButton.Location = new Point(13, 298);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(128, 53);
            zeroButton.TabIndex = 0;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += resultTextBox_Click;
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 452);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calc";
            Text = "Calkulator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button nineButton;
        private Button equalsButton;
        private Button commaButton;
        private Button eightButton;
        private Button fiveButton;
        private Button twoButton;
        private Button sevenButton;
        private Button fourButton;
        private Button oneButton;
        private Button sixButton;
        private Button threeButton;
        private Button clearButton;
        private Button zeroButton;
        private Button subtractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private Button additionButton;
        private TextBox resultTextBox;
        private Label calcName;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}