
namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bit_in_ASCII = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ASCII_in_bit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Clear_All_TextBox = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 83);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 83);
            this.textBox2.TabIndex = 1;
            // 
            // bit_in_ASCII
            // 
            this.bit_in_ASCII.Location = new System.Drawing.Point(616, 97);
            this.bit_in_ASCII.Name = "bit_in_ASCII";
            this.bit_in_ASCII.Size = new System.Drawing.Size(98, 23);
            this.bit_in_ASCII.TabIndex = 2;
            this.bit_in_ASCII.Text = "_6bit_in_ASCII";
            this.bit_in_ASCII.UseVisualStyleBackColor = true;
            this.bit_in_ASCII.Click += new System.EventHandler(this.bit_in_ASCII_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convert 6 bit in ASCII";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Convert ASCII in 6 bit";
            // 
            // ASCII_in_bit
            // 
            this.ASCII_in_bit.Location = new System.Drawing.Point(616, 243);
            this.ASCII_in_bit.Name = "ASCII_in_bit";
            this.ASCII_in_bit.Size = new System.Drawing.Size(98, 23);
            this.ASCII_in_bit.TabIndex = 6;
            this.ASCII_in_bit.Text = "ASCII_in_6bit";
            this.ASCII_in_bit.UseVisualStyleBackColor = true;
            this.ASCII_in_bit.Click += new System.EventHandler(this.ASCII_in_bit_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(359, 218);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 83);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(48, 218);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 83);
            this.textBox4.TabIndex = 4;
            // 
            // Clear_All_TextBox
            // 
            this.Clear_All_TextBox.Location = new System.Drawing.Point(616, 328);
            this.Clear_All_TextBox.Name = "Clear_All_TextBox";
            this.Clear_All_TextBox.Size = new System.Drawing.Size(98, 23);
            this.Clear_All_TextBox.TabIndex = 8;
            this.Clear_All_TextBox.Text = "Clear All TextBox";
            this.Clear_All_TextBox.UseVisualStyleBackColor = true;
            this.Clear_All_TextBox.Click += new System.EventHandler(this.Clear_All_TextBox_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(598, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 369);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Clear_All_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ASCII_in_bit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bit_in_ASCII);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Converter ASCII in 6 bit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bit_in_ASCII;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ASCII_in_bit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Clear_All_TextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

