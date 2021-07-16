using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mapharmacy
{
    public partial class Medicament : Form
    {
        public Medicament()
        {
            InitializeComponent();
            RemplirFab();
            afficher();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Mapharmacie;Integrated Security=True");

        private void RemplirFab()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from FabricantTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FabNum", typeof(int));
            dt.Load(Rdr);
            fabCb.ValueMember = "FabNum";
            fabCb.DataSource = dt;
            Con.Close();
        }

        private void Reinitialiser()
        {
            NomTb.Text = "";
            PrixTb.Text = "";
            QtTb.Text = "";
         
            //Cle = 0;

        }

        private void afficher()
        {
            Con.Open();
            string Req = "select * from MedicamentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MedsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Medicament_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || PrixTb.Text == "" || QtTb.Text == "" || fabCb.SelectedIndex == -1)
            {
                MessageBox.Show("Completez les information Svp");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "insert into MedicamentTbl values('" + NomTb.Text + "'," + PrixTb.Text + "," + QtTb.Text + "," + fabCb.SelectedValue.ToString() + ", '" + ExpDate.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicamant Ajoutes avec Success");
                    Con.Close();
                    afficher();
                    Reinitialiser();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Fabricants Fab = new Fabricants();
            Fab.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

           
            Form1 F1 = new Form1();

            F1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Facture Fact = new Facture();

            Fact.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Commande co = new Commande();
            co.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
