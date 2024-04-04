namespace Calculator
{
    partial class Form1
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
            txtDisplay = new TextBox();
            btnBackSpace = new Button();
            btnClear = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnReciprocal = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnEquals = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnAdd = new Button();
            btnDecimal = new Button();
            btnSign = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(36, 21);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(280, 31);
            txtDisplay.TabIndex = 0;
            txtDisplay.TabStop = false;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            btnBackSpace.ForeColor = Color.Red;
            btnBackSpace.Location = new Point(36, 70);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(103, 45);
            btnBackSpace.TabIndex = 0;
            btnBackSpace.Text = "Back";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(155, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.Highlight;
            btn7.Location = new Point(36, 128);
            btn7.Name = "btn7";
            btn7.Size = new Size(45, 45);
            btn7.TabIndex = 2;
            btn7.Tag = "";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.Highlight;
            btn8.Location = new Point(94, 128);
            btn8.Name = "btn8";
            btn8.Size = new Size(45, 45);
            btn8.TabIndex = 3;
            btn8.Tag = "";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.Highlight;
            btn9.Location = new Point(152, 128);
            btn9.Name = "btn9";
            btn9.Size = new Size(45, 45);
            btn9.TabIndex = 4;
            btn9.Tag = "";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(210, 128);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(45, 45);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.ForeColor = SystemColors.Highlight;
            btnSqrt.Location = new Point(268, 128);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(45, 45);
            btnSqrt.TabIndex = 6;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReciprocal.ForeColor = SystemColors.Highlight;
            btnReciprocal.Location = new Point(268, 186);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(45, 45);
            btnReciprocal.TabIndex = 11;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(210, 186);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(45, 45);
            btnMultiply.TabIndex = 10;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.Highlight;
            btn6.Location = new Point(152, 186);
            btn6.Name = "btn6";
            btn6.Size = new Size(45, 45);
            btn6.TabIndex = 9;
            btn6.Tag = "";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.Highlight;
            btn5.Location = new Point(94, 186);
            btn5.Name = "btn5";
            btn5.Size = new Size(45, 45);
            btn5.TabIndex = 8;
            btn5.Tag = "";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.Highlight;
            btn4.Location = new Point(36, 186);
            btn4.Name = "btn4";
            btn4.Size = new Size(45, 45);
            btn4.TabIndex = 7;
            btn4.Tag = "";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.ForeColor = Color.Red;
            btnEquals.Location = new Point(268, 244);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(45, 103);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(210, 244);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(45, 45);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.Highlight;
            btn3.Location = new Point(152, 244);
            btn3.Name = "btn3";
            btn3.Size = new Size(45, 45);
            btn3.TabIndex = 14;
            btn3.Tag = "";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.Highlight;
            btn2.Location = new Point(94, 244);
            btn2.Name = "btn2";
            btn2.Size = new Size(45, 45);
            btn2.TabIndex = 13;
            btn2.Tag = "";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.Highlight;
            btn1.Location = new Point(36, 244);
            btn1.Name = "btn1";
            btn1.Size = new Size(45, 45);
            btn1.TabIndex = 12;
            btn1.Tag = "";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(210, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 45);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.ForeColor = SystemColors.Highlight;
            btnDecimal.Location = new Point(152, 302);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(45, 45);
            btnDecimal.TabIndex = 19;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSign.ForeColor = SystemColors.Highlight;
            btnSign.Location = new Point(94, 302);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(45, 45);
            btnSign.TabIndex = 18;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.Highlight;
            btn0.Location = new Point(36, 302);
            btn0.Name = "btn0";
            btn0.Size = new Size(45, 45);
            btn0.TabIndex = 17;
            btn0.Tag = "";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 382);
            Controls.Add(btnAdd);
            Controls.Add(btnDecimal);
            Controls.Add(btnSign);
            Controls.Add(btn0);
            Controls.Add(btnEquals);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnReciprocal);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSqrt);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnClear);
            Controls.Add(btnBackSpace);
            Controls.Add(txtDisplay);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnBackSpace;
        private Button btnClear;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnReciprocal;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnEquals;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnAdd;
        private Button btnDecimal;
        private Button btnSign;
        private Button btn0;
    }
}