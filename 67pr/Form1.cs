using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _67pr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                int novoeChislo = i;
                SmenitZnak(ref novoeChislo);
                vivod1.Text += novoeChislo + "\n";
            }
        }

        public float Rast(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public float Geron(float a, float b, float c)
        {
            float p = (a + b + c) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void SmenitZnak(ref int chislo)
        {
            if (chislo % 2 == 0)
                chislo *= -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x1, x2, x3, x4, y1, y2, y3, y4;

            x1 = 1;
            y1 = 1;
            
            x2 = 3;
            y2 = 1;

            x3 = 1;
            y3 = 4;

            x4 = 2;
            y4 = 4;

            float s1 = Geron(Rast(x1, y1, x2, y2), Rast(x1, y1, x3, y3), Rast(x2, y2, x3, y3));
            float s2 = Geron(Rast(x2, y2, x4, y4), Rast(x4, y4, x3, y3), Rast(x2, y2, x3, y3));

            float min = Math.Min(s1, s2);

            vivod2.Text += "Площадь 1=" + s1 + "\n";
            vivod2.Text += "Площадь 2=" + s2 + "\n";
            vivod2.Text += "Наименьшая плошадь=" + min + "\n";
        }
    }
}
