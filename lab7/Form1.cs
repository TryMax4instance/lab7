using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Func(double x, double y)
            {
                return (y - Math.Pow(y,2))*x;
            };
            
            double Tocn(double x)
            {
                return 1.0 / (1.0 - ((2.0 * Math.Exp(-0.5 * x * x)) / 3.0));
            };

            double a = 0.0; double b = 0.0; double h = 0.0;

            a = Convert.ToDouble(ABox.Text);
            b = Convert.ToDouble(BBox.Text);
            h = Convert.ToDouble(StepBox.Text);

	        chart1.Series[0].Points.Clear();
	        chart1.Series[1].Points.Clear();
	        chart1.Series[2].Points.Clear();

            double n = (b - a) / h;

            double[] X = new double[Convert.ToInt32(n)];
            double[] k1 = new double[Convert.ToInt32(n)];
            double[] k2 = new double[Convert.ToInt32(n)];
            double[] k3 = new double[Convert.ToInt32(n)];
            double[] k4 = new double[Convert.ToInt32(n)];
            double[] Yrk = new double[Convert.ToInt32(n + 1)];

            double[] Xdp = new double[Convert.ToInt32(n)];
            double[] XY = new double[Convert.ToInt32(n)];
            double[] Ydp = new double[Convert.ToInt32(n)];
            double[] Yme = new double[Convert.ToInt32(n + 1)];

            double[] Ytn = new double[Convert.ToInt32(n + 1)];

            Yrk[0] = Yme[0] = Ytn[0] = 3.0; X[0]=0.0;

            dataGridView1.Rows.Clear();

            //calculate
            for (int i = 0; i < n; i++)
            {
                X[i] = X[0] + i * h;

                //RK
                k1[i] = Func(X[i], Yrk[i]);
                k2[i] = Func(X[i] + (h / 2.0), Yrk[i] + ((h * k1[i]) / 2.0));
                k3[i] = Func(X[i] + (h / 2.0), Yrk[i] + ((h * k2[i]) / 2.0));
                k4[i] = Func(X[i] + h, Yrk[i] + (h * k3[i]));
                Yrk[i+1] = Yrk[i] + ((h / 6.0) * (k1[i] + (2.0 * k2[i]) + (2.0 * k3[i]) + k4[i]));
                //======================================================================//

                //ME
                Xdp[i] = X[i] + (h * 2.0);
                Ydp[i] = Yme[i] + (h / 2.0) * Func(X[i], Yme[i]);
                XY[i] = Func(Xdp[i], Ydp[i]);
                Yme[i+1] = Yme[i] + ( h * XY[i]);
                //=======================================================================//

                //Tocn
                Ytn[i] = Tocn(X[i]);
                //======================================================================//

                dataGridView1.Rows.Add(i+1, Yrk[i], Yme[i], Ytn[i]);

                chart1.Series[0].Points.AddXY(i, Yrk[i]);
                chart1.Series[1].Points.AddXY(i, Yme[i]);
                chart1.Series[2].Points.AddXY(i, Ytn[i]);
            }
        }
    }
}
