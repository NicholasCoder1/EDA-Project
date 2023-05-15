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

namespace Login_Form
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-KO7GKV65\SQLEXPRESS;Initial Catalog=""LogIn Info"";Integrated Security=True");
        private object txt_password;
        private object txt_username;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username, Password;

            Username = txt_username.Text;
            Password = txt_password.Text;

            try


            {
                String querry = "SELECT" FROM LogIn_info Where username = '"+ txt_username.Text+"' AND Password = '"+txt_password.Text+"'";


                 SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = txt_username.Text;
                    Password = txt_password.Text;

                    //Page that needed to be loaded next
                    FrmPatientInformation

                }
            }
            catch

            {
                MessageBox.Show("Invalid Input");
            }


            finally


            {

                conn.Open();

            }



            System.Windows.Forms.MessageBox.Show("Login successful");
            }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSwallow_Click(object sender, EventArgs e)
        {

        }
    }

}