using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pdd = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pdd += 1;
            BardeProgression.Value = pdd;
            Pourcentagelbl.Text = pdd + "%";
            if (BardeProgression.Value == 100)
            {
                BardeProgression.Value = 0;
                timer1.Stop();
                Connexion MyCon = new Connexion();
                MyCon.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
