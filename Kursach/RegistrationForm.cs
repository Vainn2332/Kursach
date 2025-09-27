using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {//162, 197, 35 лайм
            try
            {
                FormGradientPainter formGradientPainter = new FormGradientPainter();
                Color color1 = Color.FromArgb(122, 30, 51);
                Color color2 = Color.FromArgb(215, 72, 92);
                Color color3 = Color.FromArgb(248, 192, 200);
                formGradientPainter.CreateLinearGradient(this, color1, color2, color3, e);
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

        private void Registrationbutton_Click(object sender, EventArgs e)
        {

        }

        private void ToAuthorisationlabel_MouseEnter(object sender, EventArgs e)
        {
            ToAuthorisationlabel.ForeColor = Color.Blue;

        }

        private void ToAuthorisationlabel_MouseLeave(object sender, EventArgs e)
        {
            ToAuthorisationlabel.ForeColor = Color.Black;

        }

        private void ToAuthorisationlabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

