namespace Kursach
{
    partial class RegistrationForm
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
            this.Registrationlabel = new System.Windows.Forms.Label();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Registrationbutton = new System.Windows.Forms.Button();
            this.ToAuthorisationlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registrationlabel
            // 
            this.Registrationlabel.AutoSize = true;
            this.Registrationlabel.BackColor = System.Drawing.Color.Transparent;
            this.Registrationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrationlabel.Location = new System.Drawing.Point(273, 25);
            this.Registrationlabel.Name = "Registrationlabel";
            this.Registrationlabel.Size = new System.Drawing.Size(186, 33);
            this.Registrationlabel.TabIndex = 0;
            this.Registrationlabel.Text = "Регистрация";
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loginlabel.Location = new System.Drawing.Point(222, 114);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(55, 20);
            this.Loginlabel.TabIndex = 2;
            this.Loginlabel.Text = "Логин";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passwordlabel.Location = new System.Drawing.Point(222, 218);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(67, 20);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "Пароль";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogintextBox.Location = new System.Drawing.Point(225, 150);
            this.LogintextBox.Multiline = true;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(290, 44);
            this.LogintextBox.TabIndex = 4;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordtextBox.Location = new System.Drawing.Point(225, 247);
            this.PasswordtextBox.Multiline = true;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(290, 44);
            this.PasswordtextBox.TabIndex = 5;
            // 
            // Registrationbutton
            // 
            this.Registrationbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Registrationbutton.FlatAppearance.BorderSize = 2;
            this.Registrationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrationbutton.Location = new System.Drawing.Point(241, 344);
            this.Registrationbutton.Name = "Registrationbutton";
            this.Registrationbutton.Size = new System.Drawing.Size(247, 88);
            this.Registrationbutton.TabIndex = 6;
            this.Registrationbutton.Text = "Зарегестрироваться";
            this.Registrationbutton.UseVisualStyleBackColor = true;
            this.Registrationbutton.Click += new System.EventHandler(this.Registrationbutton_Click);
            // 
            // ToAuthorisationlabel
            // 
            this.ToAuthorisationlabel.AutoSize = true;
            this.ToAuthorisationlabel.BackColor = System.Drawing.Color.Transparent;
            this.ToAuthorisationlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToAuthorisationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToAuthorisationlabel.Location = new System.Drawing.Point(32, 366);
            this.ToAuthorisationlabel.Name = "ToAuthorisationlabel";
            this.ToAuthorisationlabel.Size = new System.Drawing.Size(118, 40);
            this.ToAuthorisationlabel.TabIndex = 14;
            this.ToAuthorisationlabel.Text = "Есть аккаунт?\r\nВойти";
            this.ToAuthorisationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToAuthorisationlabel.Click += new System.EventHandler(this.ToAuthorisationlabel_Click);
            this.ToAuthorisationlabel.MouseEnter += new System.EventHandler(this.ToAuthorisationlabel_MouseEnter);
            this.ToAuthorisationlabel.MouseLeave += new System.EventHandler(this.ToAuthorisationlabel_MouseLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(732, 472);
            this.Controls.Add(this.ToAuthorisationlabel);
            this.Controls.Add(this.Registrationbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Registrationlabel);
            this.Name = "RegistrationForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Registrationlabel;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button Registrationbutton;
        private System.Windows.Forms.Label ToAuthorisationlabel;
    }
}

