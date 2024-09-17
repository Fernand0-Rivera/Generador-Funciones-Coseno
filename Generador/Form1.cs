using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador{
    public partial class Form1 : Form{
        double ti, tf, g, t, T;

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Firma_2.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        int n;
        public Form1(){
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e){
            double h;
            ti = 0;
            tf = 10;
            n = chart1.Width;
            T = DateTime.Now.Second;
            h = (tf - ti) / n;
            chart1.Series["Series1"].Points.Clear();
            for(int k = 0; k < n; k++) {
                t = ti + k * h;
                g = fu(t);
                chart1.Series["Series1"].Points.AddXY(t,g);
            }
        }//Termina timer
        double fu(double t) {
            double r = 0;
            if (cB1.Text == "Cos") { 
                r = Math.Cos(t - T);
            }
            return r;
        }
        
    }
}
