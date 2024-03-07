namespace Hesap_Makinesi
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(48, 60);
            label1.Name = "label1";
            label1.Size = new Size(84, 35);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(204, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 41);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(204, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 41);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(48, 124);
            label2.Name = "label2";
            label2.Size = new Size(84, 35);
            label2.TabIndex = 2;
            label2.Text = "Sayı 2:";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(48, 195);
            button1.Name = "button1";
            button1.Size = new Size(154, 55);
            button1.TabIndex = 4;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(535, 92);
            label3.Name = "label3";
            label3.Size = new Size(41, 35);
            label3.TabIndex = 5;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(415, 92);
            label4.Name = "label4";
            label4.Size = new Size(114, 35);
            label4.TabIndex = 6;
            label4.Text = "Sonuç  =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(48, 361);
            label5.Name = "label5";
            label5.Size = new Size(82, 35);
            label5.TabIndex = 7;
            label5.Text = "2.Sayı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(48, 308);
            label6.Name = "label6";
            label6.Size = new Size(82, 35);
            label6.TabIndex = 8;
            label6.Text = "1.Sayı:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(170, 361);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 41);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(170, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(128, 41);
            textBox4.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(48, 443);
            button2.Name = "button2";
            button2.Size = new Size(154, 55);
            button2.TabIndex = 11;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(400, 338);
            label7.Name = "label7";
            label7.Size = new Size(114, 35);
            label7.TabIndex = 13;
            label7.Text = "Sonuç  =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(520, 338);
            label8.Name = "label8";
            label8.Size = new Size(41, 35);
            label8.TabIndex = 12;
            label8.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(1004, 551);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hesap Makinesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Label label7;
        private Label label8;
    }
}
