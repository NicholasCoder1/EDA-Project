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

namespace AppointmentForm1._0
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNdetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CKC7CQF\\SQLEXPRESS;Initial Catalog=STC;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                
                string fName = "";
                string lName = "";
                string email = "";
                


                string insertQuery = "INSERT INTO Patient (PatientID, fName, lName, email) VALUES (@PatientID, @fName, @lName,  @email)";
                

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {

                    
                    command.Parameters.AddWithValue("@fName", fName);
                    command.Parameters.AddWithValue("@lName", lName);
                    command.Parameters.AddWithValue("@email", email);
                    

                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Appointment information inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert Appointment information.");
                    }

                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Appointment Cancelled");
            this.Close();
        }
    }
}
