using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                FormGradientPainter fgp = new FormGradientPainter();
                Color color1 = Color.FromArgb(146, 99, 165);
                Color color2 = Color.FromArgb(125, 159, 207);
                Color color3 = Color.FromArgb(171, 206, 217);//166, 201, 212
                fgp.CreateLinearGradient(this, color1, color2, color3, e);
            }
            catch { }           
        }
        protected override void OnResize(EventArgs e)
        {//позволяет нормально работать градиенту при изменении размера формы
            try
            {
                base.OnResize(e);
                this.Invalidate();

            }
            catch { }
        }

        private void ToRegistrationlabel_MouseEnter(object sender, EventArgs e)
        {
            ToRegistrationlabel.ForeColor = Color.Blue;
        }

        private void ToRegistrationlabel_MouseLeave(object sender, EventArgs e)
        {
            ToRegistrationlabel.ForeColor = Color.Black;

        }

        private void ToRegistrationlabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
