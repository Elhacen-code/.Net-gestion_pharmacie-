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
    public partial class Ajents : Form
    {
        public Ajents()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Mapharmacie;Integrated Security=True");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || GenreCb.SelectedIndex == -1 || PassTb.Text == "" || TelTb.Text == "")
            {
                MessageBox.Show("Completez les information Svp");
            }
            else
            {
                try
                {

                    Con.Open();
                    string Req = "insert into AgentTbl values('" + NomTb.Text + "','" + DDNdate.Value.Date + "','" + TelTb.Text + "','" + GenreCb.SelectedItem.ToString() + "','" + PassTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajant Ajoutes avec Success");
                    Con.Close();
                    //afficher();
                    //Reinitialiser();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Ajents_Load(object sender, EventArgs e)
        {

        }
    }
}
