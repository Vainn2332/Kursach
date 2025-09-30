using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    internal class FormGradientPainter
    {
        public void CreateLinearGradient(Form form,Color color1,Color color2,Color color3,PaintEventArgs e)
        {//заливает градиентом данную форму 3 цветами от верхнего левого угла до правого нижнего
            Point p1 = new Point(0, 0);
            Point p2 = new Point(form.Width,form.Height);
            Color[] colors = new Color[]
            {
                 color1,
                 Color.FromArgb((color1.R+color2.R)/2,(color1.G+color2.G)/2,(color1.B+color2.B)/2),
                 color2,
                 Color.FromArgb((color2.R+color3.R)/2,(color2.G+color3.G)/2,(color2.B+color3.B)/2),   // Промежуточные цвета
                 color3
            };
            Rectangle rect = form.ClientRectangle;
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, colors[0], colors[4], LinearGradientMode.ForwardDiagonal);
            ColorBlend blend = new ColorBlend();
            blend.Colors = colors;
            blend.Positions = new float[] { 0f, 0.2f, 0.5f, 0.8f, 1f };
            linearGradientBrush.InterpolationColors = blend;
            e.Graphics.FillRectangle(linearGradientBrush, rect);
        }
    }
}
