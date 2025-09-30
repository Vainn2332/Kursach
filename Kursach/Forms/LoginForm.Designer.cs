namespace Kursach
{
    partial class LoginForm
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
            this.Loginbutton = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Authorisationlabel = new System.Windows.Forms.Label();
            this.ToRegistrationlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Loginbutton.FlatAppearance.BorderSize = 2;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loginbutton.Location = new System.Drawing.Point(241, 344);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(247, 88);
            this.Loginbutton.TabIndex = 12;
            this.Loginbutton.Text = "Войти";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordtextBox.Location = new System.Drawing.Point(225, 247);
            this.PasswordtextBox.Multiline = true;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(290, 44);
            this.PasswordtextBox.TabIndex = 11;
            // 
            // LogintextBox
            // 
            this.LogintextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogintextBox.Location = new System.Drawing.Point(225, 150);
            this.LogintextBox.Multiline = true;
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(290, 44);
            this.LogintextBox.TabIndex = 10;
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passwordlabel.Location = new System.Drawing.Point(222, 218);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(67, 20);
            this.Passwordlabel.TabIndex = 9;
            this.Passwordlabel.Text = "Пароль";
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loginlabel.Location = new System.Drawing.Point(222, 114);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(55, 20);
            this.Loginlabel.TabIndex = 8;
            this.Loginlabel.Text = "Логин";
            // 
            // Authorisationlabel
            // 
            this.Authorisationlabel.AutoSize = true;
            this.Authorisationlabel.BackColor = System.Drawing.Color.Transparent;
            this.Authorisationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorisationlabel.Location = new System.Drawing.Point(273, 25);
            this.Authorisationlabel.Name = "Authorisationlabel";
            this.Authorisationlabel.Size = new System.Drawing.Size(190, 33);
            this.Authorisationlabel.TabIndex = 7;
            this.Authorisationlabel.Text = "Авторизация";
            // 
            // ToRegistrationlabel
            // 
            this.ToRegistrationlabel.AutoSize = true;
            this.ToRegistrationlabel.BackColor = System.Drawing.Color.Transparent;
            this.ToRegistrationlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToRegistrationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToRegistrationlabel.Location = new System.Drawing.Point(26, 378);
            this.ToRegistrationlabel.Name = "ToRegistrationlabel";
            this.ToRegistrationlabel.Size = new System.Drawing.Size(169, 40);
            this.ToRegistrationlabel.TabIndex = 13;
            this.ToRegistrationlabel.Text = "Нет аккаунта?\r\nЗарегестрироваться";
            this.ToRegistrationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToRegistrationlabel.Click += new System.EventHandler(this.ToRegistrationlabel_Click);
            this.ToRegistrationlabel.MouseEnter += new System.EventHandler(this.ToRegistrationlabel_MouseEnter);
            this.ToRegistrationlabel.MouseLeave += new System.EventHandler(this.ToRegistrationlabel_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(72)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(732, 472);
            this.Controls.Add(this.ToRegistrationlabel);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Authorisationlabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Authorisationlabel;
        private System.Windows.Forms.Label ToRegistrationlabel;
    }
}