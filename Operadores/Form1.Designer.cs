namespace Operadores
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.txt_number1 = new System.Windows.Forms.TextBox();
            this.txt_number2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.txt_rest = new System.Windows.Forms.TextBox();
            this.txt_mult = new System.Windows.Forms.TextBox();
            this.txt_div = new System.Windows.Forms.TextBox();
            this.txt_pow = new System.Windows.Forms.TextBox();
            this.txt_root = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_number2);
            this.groupBox1.Controls.Add(this.txt_number1);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.btn_calc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(267, 22);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(267, 71);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(75, 23);
            this.btn_clean.TabIndex = 3;
            this.btn_clean.Text = "Limpiar";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.Btn_clean_Click);
            // 
            // txt_number1
            // 
            this.txt_number1.Location = new System.Drawing.Point(65, 29);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(100, 20);
            this.txt_number1.TabIndex = 4;
            // 
            // txt_number2
            // 
            this.txt_number2.Location = new System.Drawing.Point(65, 71);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(100, 20);
            this.txt_number2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_root);
            this.groupBox2.Controls.Add(this.txt_pow);
            this.groupBox2.Controls.Add(this.txt_div);
            this.groupBox2.Controls.Add(this.txt_mult);
            this.groupBox2.Controls.Add(this.txt_rest);
            this.groupBox2.Controls.Add(this.txt_sum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Multiplicación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "División:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Potencia:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Raíz:";
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(92, 20);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(100, 20);
            this.txt_sum.TabIndex = 6;
            this.txt_sum.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txt_rest
            // 
            this.txt_rest.Location = new System.Drawing.Point(92, 60);
            this.txt_rest.Name = "txt_rest";
            this.txt_rest.Size = new System.Drawing.Size(100, 20);
            this.txt_rest.TabIndex = 7;
            this.txt_rest.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txt_mult
            // 
            this.txt_mult.Location = new System.Drawing.Point(92, 101);
            this.txt_mult.Name = "txt_mult";
            this.txt_mult.Size = new System.Drawing.Size(100, 20);
            this.txt_mult.TabIndex = 8;
            // 
            // txt_div
            // 
            this.txt_div.Location = new System.Drawing.Point(266, 20);
            this.txt_div.Name = "txt_div";
            this.txt_div.Size = new System.Drawing.Size(100, 20);
            this.txt_div.TabIndex = 9;
            // 
            // txt_pow
            // 
            this.txt_pow.Location = new System.Drawing.Point(266, 60);
            this.txt_pow.Name = "txt_pow";
            this.txt_pow.Size = new System.Drawing.Size(100, 20);
            this.txt_pow.TabIndex = 10;
            // 
            // txt_root
            // 
            this.txt_root.Location = new System.Drawing.Point(266, 97);
            this.txt_root.Name = "txt_root";
            this.txt_root.Size = new System.Drawing.Size(100, 20);
            this.txt_root.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".:. Estructuras Secuenciales .:.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number2;
        private System.Windows.Forms.TextBox txt_number1;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_root;
        private System.Windows.Forms.TextBox txt_pow;
        private System.Windows.Forms.TextBox txt_div;
        private System.Windows.Forms.TextBox txt_mult;
        private System.Windows.Forms.TextBox txt_rest;
        private System.Windows.Forms.TextBox txt_sum;
    }
}

