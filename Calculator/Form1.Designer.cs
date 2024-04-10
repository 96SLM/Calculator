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
            btnMemoryStore = new Button();
            btnMemoryRecall = new Button();
            btnMemoryClear = new Button();
            btnMemory = new Button();
            btnMemoryPlus = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(22, 12);
            txtDisplay.Margin = new Padding(2);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(247, 23);
            txtDisplay.TabIndex = 0;
            txtDisplay.TabStop = false;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackSpace
            // 
            btnBackSpace.ForeColor = Color.Red;
            btnBackSpace.Location = new Point(72, 41);
            btnBackSpace.Margin = new Padding(2);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(72, 27);
            btnBackSpace.TabIndex = 0;
            btnBackSpace.Text = "Back";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(155, 41);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 27);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.Highlight;
            btn7.Location = new Point(72, 76);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(32, 27);
            btn7.TabIndex = 2;
            btn7.Tag = "";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.Highlight;
            btn8.Location = new Point(113, 76);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(32, 27);
            btn8.TabIndex = 3;
            btn8.Tag = "";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.Highlight;
            btn9.Location = new Point(153, 76);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(32, 27);
            btn9.TabIndex = 4;
            btn9.Tag = "";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(194, 76);
            btnDivide.Margin = new Padding(2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(32, 27);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 8F);
            btnSqrt.ForeColor = SystemColors.Highlight;
            btnSqrt.Location = new Point(235, 76);
            btnSqrt.Margin = new Padding(2);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(32, 27);
            btnSqrt.TabIndex = 6;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Font = new Font("Segoe UI", 8F);
            btnReciprocal.ForeColor = SystemColors.Highlight;
            btnReciprocal.Location = new Point(235, 111);
            btnReciprocal.Margin = new Padding(2);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(32, 27);
            btnReciprocal.TabIndex = 11;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = true;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(194, 111);
            btnMultiply.Margin = new Padding(2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(32, 27);
            btnMultiply.TabIndex = 10;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.Highlight;
            btn6.Location = new Point(153, 111);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(32, 27);
            btn6.TabIndex = 9;
            btn6.Tag = "";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.Highlight;
            btn5.Location = new Point(113, 111);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(32, 27);
            btn5.TabIndex = 8;
            btn5.Tag = "";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.Highlight;
            btn4.Location = new Point(72, 111);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(32, 27);
            btn4.TabIndex = 7;
            btn4.Tag = "";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEquals.ForeColor = Color.Red;
            btnEquals.Location = new Point(235, 145);
            btnEquals.Margin = new Padding(2);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(32, 62);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(194, 145);
            btnSubtract.Margin = new Padding(2);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(32, 27);
            btnSubtract.TabIndex = 15;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.Highlight;
            btn3.Location = new Point(153, 145);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(32, 27);
            btn3.TabIndex = 14;
            btn3.Tag = "";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.Highlight;
            btn2.Location = new Point(113, 145);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(32, 27);
            btn2.TabIndex = 13;
            btn2.Tag = "";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.Highlight;
            btn1.Location = new Point(72, 145);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(32, 27);
            btn1.TabIndex = 12;
            btn1.Tag = "";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Red;
            btnAdd.Location = new Point(194, 180);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(32, 27);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDecimal.ForeColor = SystemColors.Highlight;
            btnDecimal.Location = new Point(153, 180);
            btnDecimal.Margin = new Padding(2);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(32, 27);
            btnDecimal.TabIndex = 19;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSign.ForeColor = SystemColors.Highlight;
            btnSign.Location = new Point(113, 180);
            btnSign.Margin = new Padding(2);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(32, 27);
            btnSign.TabIndex = 18;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.Highlight;
            btn0.Location = new Point(72, 180);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(32, 27);
            btn0.TabIndex = 17;
            btn0.Tag = "";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btnMemoryStore
            // 
            btnMemoryStore.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMemoryStore.ForeColor = Color.Red;
            btnMemoryStore.Location = new Point(22, 145);
            btnMemoryStore.Margin = new Padding(2);
            btnMemoryStore.Name = "btnMemoryStore";
            btnMemoryStore.Size = new Size(42, 27);
            btnMemoryStore.TabIndex = 24;
            btnMemoryStore.Tag = "";
            btnMemoryStore.Text = "MS";
            btnMemoryStore.UseVisualStyleBackColor = true;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMemoryRecall.ForeColor = Color.Red;
            btnMemoryRecall.Location = new Point(22, 111);
            btnMemoryRecall.Margin = new Padding(2);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(42, 27);
            btnMemoryRecall.TabIndex = 23;
            btnMemoryRecall.Tag = "";
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = true;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMemoryClear.ForeColor = Color.Red;
            btnMemoryClear.Location = new Point(22, 75);
            btnMemoryClear.Margin = new Padding(2);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(42, 27);
            btnMemoryClear.TabIndex = 22;
            btnMemoryClear.Tag = "";
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            // 
            // btnMemory
            // 
            btnMemory.Enabled = false;
            btnMemory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMemory.ForeColor = SystemColors.WindowText;
            btnMemory.Location = new Point(22, 41);
            btnMemory.Margin = new Padding(2);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new Size(42, 27);
            btnMemory.TabIndex = 21;
            btnMemory.Tag = "";
            btnMemory.Text = "M";
            btnMemory.UseVisualStyleBackColor = true;
            // 
            // btnMemoryPlus
            // 
            btnMemoryPlus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMemoryPlus.ForeColor = Color.Red;
            btnMemoryPlus.Location = new Point(22, 180);
            btnMemoryPlus.Margin = new Padding(2);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(42, 27);
            btnMemoryPlus.TabIndex = 25;
            btnMemoryPlus.Tag = "";
            btnMemoryPlus.Text = "M+";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 229);
            Controls.Add(btnMemoryPlus);
            Controls.Add(btnMemoryStore);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnMemory);
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
            Margin = new Padding(2);
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
        private Button btnMemoryStore;
        private Button btnMemoryRecall;
        private Button btnMemoryClear;
        private Button btnMemory;
        private Button btnMemoryPlus;
    }
}