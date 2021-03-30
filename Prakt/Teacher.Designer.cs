namespace Prakt
{
    partial class Teacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_log = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.but_Teacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вход";
            // 
            // TB_log
            // 
            this.TB_log.Location = new System.Drawing.Point(33, 81);
            this.TB_log.Name = "TB_log";
            this.TB_log.Size = new System.Drawing.Size(260, 20);
            this.TB_log.TabIndex = 3;
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(33, 159);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(260, 20);
            this.TB_pass.TabIndex = 4;
            // 
            // but_Teacher
            // 
            this.but_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.but_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Teacher.Location = new System.Drawing.Point(123, 197);
            this.but_Teacher.Name = "but_Teacher";
            this.but_Teacher.Size = new System.Drawing.Size(75, 23);
            this.but_Teacher.TabIndex = 5;
            this.but_Teacher.Text = "Войти";
            this.but_Teacher.UseVisualStyleBackColor = false;
            this.but_Teacher.Click += new System.EventHandler(this.but_Teacher_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(165)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(322, 232);
            this.Controls.Add(this.but_Teacher);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_log;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button but_Teacher;
    }
}