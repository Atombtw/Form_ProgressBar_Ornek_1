using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ProgressBarOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            pb1K.Visible = false;
            pb1Y.Visible = false;
            pb2K.Visible = false;
            pb2Y.Visible = false;
            pb3K.Visible = false;
            pb3Y.Visible = false;
            pb4K.Visible = false;
            pb4Y.Visible = false;
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Value = sayac;
            pb1K.Visible = true;
            if (progressBar1.Value % 2 == 0)
            {
                label1.BackColor = Color.Blue;
            }
            if (progressBar1.Value % 2 == 1)
            {
                label1.BackColor = Color.Black;
            }

            if (progressBar1.Value == 100)
            {
                pb1K.Visible = false;
                pb1Y.Visible = true;
                label1.ForeColor = Color.Green;
                label1.BackColor = Color.DarkTurquoise;
                timer1.Stop();
                timer2.Start();
                sayac = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar2.Value = sayac;
            pb2K.Visible = true;
            if (progressBar2.Value % 2 == 0)
            {
                label2.BackColor = Color.Blue;
            }
            if (progressBar2.Value % 2 == 1)
            {
                label2.BackColor = Color.Black;
            }
            if (progressBar2.Value == 100)
            {
                pb2K.Visible = false;
                pb2Y.Visible = true;
                label2.ForeColor = Color.Green;
                label2.BackColor = Color.DarkTurquoise;
                timer2.Stop();
                timer3.Start();
                sayac = 0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar3.Value = sayac;
            pb3K.Visible = true;
            if (progressBar3.Value % 2 == 0)
            {
                label3.BackColor = Color.Blue;
            }
            if (progressBar3.Value % 2 == 1)
            {
                label3.BackColor = Color.Black;
            }
            if (progressBar3.Value == 100)
            {
                pb3K.Visible = false;
                pb3Y.Visible = true;
                label3.ForeColor = Color.Green;
                label3.BackColor = Color.DarkTurquoise;
                timer3.Stop();
                timer4.Start();
                sayac = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar4.Value = sayac;
            pb4K.Visible = true;
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Blue;
            }
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.Black;
            }
            if (progressBar4.Value == 100)
            {
                pb4K.Visible = false;
                pb4Y.Visible = true;
                label4.ForeColor = Color.Green;
                label4.BackColor = Color.DarkTurquoise;
                timer4.Stop();
                sayac = 0;
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
                MessageBox.Show("Pastanız Hazır..");
            }
        }
    }
}