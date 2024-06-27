using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Faculty : Employee
    {
        public Faculty(int id, string firstName, string lastName, string email, string password, int phoneNumber, string type, int hourOfService, int lenghtOfService, int salary) : base(id, firstName, lastName, email, password, phoneNumber, type, hourOfService, lenghtOfService, salary)
        {

        }

        public Faculty(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');
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

        public int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }

        public int LengthOfService
        {
            get { return base.LengthOfService; }
            set { base.LengthOfService = value; }
        }

        public int HoursOfService
        {
            get { return base.HoursOfService; }
            set { base.HoursOfService = value; }
        }

        public string FacultyInfo()
        {
            string text = " ";
            text += "Id " + base.Id + "\n";
            text += "First name " + base.FirstName + "\n";
            text += "Last name " + base.LastName + "\n";
            text += "Email " + base.Email + "\n";
            text += "Password " + base.Password + "\n";
            text += "Phone number" + base.PhoneNumber + "\n";
            text += "Type " + base.Type + "\n";
            text += "Hours Of Service " + base.HoursOfService + "\n";
            text += "Lenght Of service" + base.LengthOfService + "\n";
            text += "salary" + base.Salary + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.Type + base.HoursOfService + "," + base.LengthOfService + "," + base.Salary;
        }
    }
}
