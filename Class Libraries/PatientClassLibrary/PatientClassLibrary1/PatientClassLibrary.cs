using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientClassLibrary1
{

    public class Patient
    {
        private int patientID;
        private string fName;
        private string mName;
        private string lName;
        private string gender;
        private string maritalStatus;
        private int homePhone;
        private int mobilePhone;
        private int emergencyPhone;
        private string email;
        private string medicalConditions;
        private string address;
        private int postalCode;
        private string country;
        private string mailingAddress;

        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string MiddleName
        {
            get { return mName; }
            set { mName = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        public int HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public int MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public int EmergencyPhone
        {
            get { return emergencyPhone; }
            set { emergencyPhone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MedicalConditions
        {
            get { return medicalConditions; }
            set { medicalConditions = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string State { get; set; }

        public string MailingAddress
        {
            get { return mailingAddress; }
            set { mailingAddress = value; }
        }

        public void PrintPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientID}");
            Console.WriteLine($"Name: {fName} {mName} {lName}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Marital Status: {maritalStatus}");
            Console.WriteLine($"Home Phone: {homePhone}");
            Console.WriteLine($"Mobile Phone: {mobilePhone}");
            Console.WriteLine($"Emergency Phone: {emergencyPhone}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Medical Conditions: {medicalConditions}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Postal Code: {postalCode}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Mailing Address: {mailingAddress}");
        }
    }

    
}
