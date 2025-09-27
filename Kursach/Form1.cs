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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {//162, 197, 35 лайм
         
            FormGradientPainter fgp = new FormGradientPainter();
            Color color1 = Color.FromArgb(146, 99, 165);
            Color color2 = Color.FromArgb(125, 159, 207);
            Color color3 = Color.FromArgb(196, 231, 242);

            fgp.CreateLinearGradient(this, color1, color2, color3, e);
        }


        
    }
}

