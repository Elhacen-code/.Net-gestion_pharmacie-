using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapharmacy
{
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Mapharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            NomTb.Text = "";
            FabTb.Text = "";
            DescTb.Text = "";
            

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Form1 F1 = new Form1();

            F1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (NomTb.Text == "" || FabTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Completez les information Svp");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "insert into CommandeTb values('" + NomTb.Text + "','" + FabTb.Text + "','" + DescTb.Text + "','" + Date.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Commande Ajoutes avec Success");
                    Con.Close();
                   
                    Reinitialiser();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Commande c = new Commande();
            
            this.Hide();
            c.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Medicament m = new Medicament();

            this.Hide();
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            Facture f = new Facture();

            this.Hide();
            f.Show();

        }
    }
}
