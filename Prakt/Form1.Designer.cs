namespace Prakt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_1_Rasp = new System.Windows.Forms.Label();
            this.but_Otp = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_1_Rasp
            // 
            this.l_1_Rasp.AutoSize = true;
            this.l_1_Rasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_1_Rasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(63)))));
            this.l_1_Rasp.Location = new System.Drawing.Point(129, 9);
            this.l_1_Rasp.Name = "l_1_Rasp";
            this.l_1_Rasp.Size = new System.Drawing.Size(284, 62);
            this.l_1_Rasp.TabIndex = 0;
            this.l_1_Rasp.Text = " Расписание уроков\r\nдля 1А класса";
            this.l_1_Rasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_Otp
            // 
            this.but_Otp.AllowDrop = true;
            this.but_Otp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.but_Otp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Otp.Location = new System.Drawing.Point(406, 413);
            this.but_Otp.Name = "but_Otp";
            this.but_Otp.Size = new System.Drawing.Size(85, 32);
            this.but_Otp.TabIndex = 1;
            this.but_Otp.Text = "Отправить";
            this.but_Otp.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(165)))), ((int)(((byte)(225)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(283, 240);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(255, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 384);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox2.Location = new System.Drawing.Point(28, 390);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(280, 66);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(165)))), ((int)(((byte)(225)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(549, 496);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.but_Otp);
            this.Controls.Add(this.l_1_Rasp);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Расписание уроков";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_1_Rasp;
        private System.Windows.Forms.Button but_Otp;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

