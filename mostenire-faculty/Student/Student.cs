using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Student : Person
    {
        private int _schoolYear;
        private int _studentdAge;

        public Student(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int schoolYear, int studentAge) : base( type,  id,  firstName,  lastName,  email,  password,  phoneNumber)
        {
            _schoolYear = schoolYear;
            _studentdAge = studentAge;
            base.Type = "studet";
        }

        public Student(string prorpeitati) : base(prorpeitati)
        {
            string[] token = prorpeitati.Split(',');

            _schoolYear = int.Parse(token[7]);
            _studentdAge = int.Parse(token[8]);
        }

        public int SchoolYear
        {
            get { return _schoolYear; }
            set { _schoolYear = value; }
        }

        public int StudentdAge
        {
            get { return _studentdAge; }
            set { _studentdAge = value; }
        }

        public string EmployeeInfo()
        {
            string text = " ";
            text += "Type " + base.Type + "\n";
            text += "Id " + base.Id + "\n";
            text += "First name " + base.FirstName + "\n";
            text += "Last name " + base.LastName + "\n";
            text += "Email " + base.Email + "\n";
            text += "Password " + base.Password + "\n";
            text += "Phone number" + base.PhoneNumber + "\n";
            text += "School Year " + _schoolYear + "\n";
            text += "Student age " + _studentdAge + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Type + "," + _schoolYear + "," + _studentdAge;
        }
    }
}
