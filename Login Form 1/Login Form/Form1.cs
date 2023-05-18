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

            string name = txtUsername.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
                {
                    
                    MessageBox.Show("Welcome, Admin!");
                }
                else
                {
                    
                    MessageBox.Show("Invalid username or password!");
                }




             if (txtUsername.Text == "patient" && txtPassword.Text == "patient123")
            {

                MessageBox.Show("Welcome, Patient!");
            }
            else
            {

                MessageBox.Show("Invalid username or password!");
            }
            
            

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

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

}