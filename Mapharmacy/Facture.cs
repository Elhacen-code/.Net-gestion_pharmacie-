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
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Fabricants Fb = new Fabricants();
            Fb.Show();
            this.Hide();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();

            F1.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Commande c = new Commande();

            c.Show();
            this.Hide();
        }
    }
}
