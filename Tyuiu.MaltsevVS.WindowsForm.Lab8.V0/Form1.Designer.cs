namespace Tyuiu.MaltsevVS.WindowsForm.Lab8.V0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.SolveExpress_2_1 = new System.Windows.Forms.RadioButton();
            this.SolveExpress_2_2 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_X
            // 
            this.textBox_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_X.Location = new System.Drawing.Point(139, 80);
            this.textBox_X.Multiline = true;
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(100, 31);
            this.textBox_X.TabIndex = 0;
            this.textBox_X.TextChanged += new System.EventHandler(this.textBox_X_TextChanged);
            // 
            // textBox_Y
            // 
            this.textBox_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Y.Location = new System.Drawing.Point(139, 150);
            this.textBox_Y.Multiline = true;
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(100, 31);
            this.textBox_Y.TabIndex = 1;
            this.textBox_Y.TextChanged += new System.EventHandler(this.textBox_Y_TextChanged);
            // 
            // button_calc
            // 
            this.button_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calc.Location = new System.Drawing.Point(117, 214);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(144, 50);
            this.button_calc.TabIndex = 3;
            this.button_calc.Text = "ВЫЧИСЛИТЬ";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolveExpress_2_1
            // 
            this.SolveExpress_2_1.AutoSize = true;
            this.SolveExpress_2_1.Location = new System.Drawing.Point(461, 141);
            this.SolveExpress_2_1.Name = "SolveExpress_2_1";
            this.SolveExpress_2_1.Size = new System.Drawing.Size(14, 13);
            this.SolveExpress_2_1.TabIndex = 4;
            this.SolveExpress_2_1.TabStop = true;
            this.SolveExpress_2_1.UseVisualStyleBackColor = true;
            this.SolveExpress_2_1.CheckedChanged += new System.EventHandler(this.SolveExpress_2_1_CheckedChanged);
            // 
            // SolveExpress_2_2
            // 
            this.SolveExpress_2_2.AutoSize = true;
            this.SolveExpress_2_2.Location = new System.Drawing.Point(461, 233);
            this.SolveExpress_2_2.Name = "SolveExpress_2_2";
            this.SolveExpress_2_2.Size = new System.Drawing.Size(14, 13);
            this.SolveExpress_2_2.TabIndex = 6;
            this.SolveExpress_2_2.TabStop = true;
            this.SolveExpress_2_2.UseVisualStyleBackColor = true;
            this.SolveExpress_2_2.CheckedChanged += new System.EventHandler(this.SolveExpress_2_2_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tyuiu.MaltsevVS.WindowsForm.Lab8.V0.Properties.Resources.Снимок_экрана_2023_12_05_231001;
            this.pictureBox2.Location = new System.Drawing.Point(481, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tyuiu.MaltsevVS.WindowsForm.Lab8.V0.Properties.Resources.Снимок_экрана_2023_12_05_230557;
            this.pictureBox1.Location = new System.Drawing.Point(481, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 58);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(150, 323);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(111, 24);
            this.textBox_result.TabIndex = 8;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(473, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите выражение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите значение:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(102, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "X:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(102, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "РЕЗУЛЬТАТ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Tyuiu.MaltsevVS.WindowsForm.Lab8.V0.Properties.Resources.Тюменский_Индустриальный_Университет;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 376);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SolveExpress_2_2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SolveExpress_2_1);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(743, 415);
            this.MinimumSize = new System.Drawing.Size(743, 415);
            this.Name = "Form1";
            this.Text = "Веселый калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.RadioButton SolveExpress_2_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SolveExpress_2_2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

