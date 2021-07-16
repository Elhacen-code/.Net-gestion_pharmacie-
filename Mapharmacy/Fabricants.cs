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
    public partial class Fabricants : Form
    {
        public Fabricants()
        {
            InitializeComponent();
            afficher();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Mapharmacie;Integrated Security=True");
        private void Reinitialiser()
        {
            NomTb.Text = "";
            AddTb.Text = "";
            DescTb.Text = "";
            TelTb.Text = "";
            Cle = 0;

        }

        private void afficher()
        {
            Con.Open();
            string Req = "select * from FabricantTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FabricatsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || AddTb.Text == "" || DescTb.Text == "" || TelTb.Text == "")
            {
                MessageBox.Show("Completez les information Svp");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "insert into FabricantTbl values('" + NomTb.Text + "','" + AddTb.Text + "','" + DescTb.Text + "','" + TelTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Ajoutes avec Success");
                    Con.Close();
                    afficher();
                    Reinitialiser();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }

        int Cle = 0;
        private void FabricatsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = FabricatsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AddTb.Text = FabricatsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DescTb.Text = FabricatsDGV.SelectedRows[0].Cells[3].Value.ToString();
            TelTb.Text = FabricatsDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (NomTb.Text == "")

                Cle = 0;
            else
                Cle = Convert.ToInt32(FabricatsDGV.SelectedRows[0].Cells[0].Value.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Cle==0)
            {
                MessageBox.Show("Selectonner le fabricant a effacer");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "delete  from FabricantTbl where FabNum="+Cle+"";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Supprimer avec Success");
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (NomTb.Text == "" || AddTb.Text == "" || DescTb.Text == "" || TelTb.Text == "")
            {
                MessageBox.Show("Information manquant");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "update  FabricantTbl set FabNom='"+NomTb.Text+"', FabAd='"+AddTb.Text+"', FabDecr='"+DescTb.Text+"', FabTel='"+TelTb.Text+"' where FabNum='"+Cle+"'";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Modifier avec Success");
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
            Medicament Med = new Medicament();
            Med.Show();
            this.Hide();
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

        private void Fabricants_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Commande co = new Commande();
            co.Show();
            this.Hide();
        }
    }
}
