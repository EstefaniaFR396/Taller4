namespace Frontend.Windows
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
            btn7 = new Button();
            btn8 = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btnMultiply = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnResul = new Button();
            btnCloseParenthesis = new Button();
            btnMinus = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnOpenParenthesis = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.FromArgb(128, 255, 128);
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.MenuText;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(535, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 60);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 52);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(90, 60);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 52);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(271, 60);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(71, 52);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 127);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 52);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(90, 127);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 52);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(359, 60);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(71, 52);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += button6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 194);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 52);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseMnemonic = false;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button7_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(90, 194);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 52);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(271, 127);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(71, 52);
            btnPlus.TabIndex = 9;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += button9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 259);
            btn0.Name = "btn0";
            btn0.Size = new Size(149, 52);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button10_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Gainsboro;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(167, 259);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(71, 52);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += button11_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(167, 194);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 52);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button12_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(167, 127);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 52);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button13_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(167, 60);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 52);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button14_Click;
            // 
            // btnResul
            // 
            btnResul.BackColor = Color.FromArgb(255, 128, 0);
            btnResul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResul.Location = new Point(271, 259);
            btnResul.Name = "btnResul";
            btnResul.Size = new Size(275, 45);
            btnResul.TabIndex = 19;
            btnResul.Text = "=";
            btnResul.UseVisualStyleBackColor = false;
            btnResul.Click += button16_Click_1;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(359, 194);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(71, 52);
            btnCloseParenthesis.TabIndex = 18;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += button17_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(359, 127);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(71, 52);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(446, 194);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(100, 52);
            btnPow.TabIndex = 16;
            btnPow.Text = "^\n ";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(446, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 52);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button20_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(446, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 52);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button21_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(271, 194);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(71, 52);
            btnOpenParenthesis.TabIndex = 22;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(547, 340);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResul);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnPow);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btnDivide;
        private Button btn4;
        private Button btn5;
        private Button btnMultiply;
        private Button btn1;
        private Button btn2;
        private Button btnPlus;
        private Button btn0;
        private Button btnDot;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnResul;
        private Button btnCloseParenthesis;
        private Button btnMinus;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
        private Button btnOpenParenthesis;
    }
}
