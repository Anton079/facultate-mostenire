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

        public Student(int schoolYear, int studentAge, int id, string firstName, string lastName, string email, string password, int phoneNumber, string type) : base( id,  firstName,  lastName,  email,  password,  phoneNumber,  type)
        {
            _schoolYear = schoolYear;
            _studentdAge = studentAge;
        }

        public int Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        public string FirstName
        {
            get { return base.FirstName; }
            set { base.FirstName = value; }
        }

        public string LastName
        {
            get { return base.LastName; }
            set { base.LastName = value; }
        }

        public string Email
        {
            get { return base.Email; }
            set { base.Email = value; }
        }

        public string Password
        {
            get { return base.Password; }
            set { base.Password = value; }
        }

        public int PhoneNumber
        {
            get { return base.PhoneNumber; }
            set { base.PhoneNumber = value; }
        }

        public string Type
        {
            get { return base.Type; }
            set { base.Type = value; }
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
            text += "Id " + base.Id + "\n";
            text += "First name " + base.FirstName + "\n";
            text += "Last name " + base.LastName + "\n";
            text += "Email " + base.Email + "\n";
            text += "Password " + base.Password + "\n";
            text += "Phone number" + base.PhoneNumber + "\n";
            text += "Type " + base.Type + "\n";
            text += "School Year " + _schoolYear + "\n";
            text += "Student age " + _studentdAge + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Type + "," + _studentdAge + "," + _schoolYear;
        }
    }
}
