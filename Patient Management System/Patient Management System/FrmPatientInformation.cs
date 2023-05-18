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
using System.Runtime.CompilerServices;

namespace Patient_Management_System
{
    public partial class FrmPatientInformation : Form
    {
        public FrmPatientInformation()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmPatientInformation_Load(object sender, EventArgs e)
        {


        }

        private void grpMedicalDetails_Enter(object sender, EventArgs e)
        {

        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show ("Information Cleared");
            
        }    

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void grpContactDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-CKC7CQF\\SQLEXPRESS;Initial Catalog=STC;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string patientID = "";
                string fName = "";
                string lName = "";
                string gender = "";
                string maritalStatus = "";
                string homePhone = "";
                string emergencyPhone = "";
                string email = "";
                string medicalConditions = "";
                string ad_dress = "";
                string postalCode = "";
                string country = "";
                string mailingAddress = "";


                string insertQuery = "INSERT INTO Patient (PatientID, fName, lName, gender, maritalStatus, homePhone, emergencyPhone, email, medicalConditions, ad_dress, postalCode, country, mailingAddress) VALUES (@PatientID, @fName, @lName, @gender, @maritalStatus, @homePhone, @emergencyPhone, @email, @medicalConditions, @ad_dress, @postalCode, @country, @mailingAddress)";


                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {

                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.Parameters.AddWithValue("@fName", fName);
                    command.Parameters.AddWithValue("@lName", lName);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@maritalStatus", maritalStatus);
                    command.Parameters.AddWithValue("@homePhone", homePhone);
                    command.Parameters.AddWithValue("@emergencyPhone", emergencyPhone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@medicalConditions", medicalConditions);
                    command.Parameters.AddWithValue("@ad_dress", ad_dress);
                    command.Parameters.AddWithValue("@postalCode", postalCode);
                    command.Parameters.AddWithValue("@country", country);
                    command.Parameters.AddWithValue("@mailingAddress", mailingAddress);


                    int rowsAffected = command.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Patient information inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert patient information.");
                    }

                }
                System.Windows.Forms.MessageBox.Show("Information Updated");
                this.Update();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Close();
        }
            
        private void grpPrimaryDetails_Enter(object sender, EventArgs e)
        {

        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDivorced_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
