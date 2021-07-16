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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Mapharmacie;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from UserTb where login='" + logTb.Text + "' and password='" + passTb.Text + "'", Con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Open();
            int i = cmd.ExecuteNonQuery();
            Con.Close();

            if (dt.Rows.Count > 0)
            {
                Fabricants fab = new Fabricants();
                fab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Voter login ou password est incorrecte!");
            }
         

        }
        private void SqlConnection(string v)
        {
            throw new NotImplementedException();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
