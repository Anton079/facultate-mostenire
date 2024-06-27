using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Employee : Person
    {
        private int _salary;
        private int _lengthOfService;
        private int _hoursOfService;

        public Employee(int salary,  int lengthOfService, int id, string firstName, string lastName, string email, string password, int phoneNumber, int hourOfService) : base ( id,  firstName,  lastName,  email,  password,  phoneNumber, "employee")
        {
            _salary = salary;
            _lengthOfService = lengthOfService;
            _hoursOfService = hourOfService;
        }

        public Employee(string proprietati):base(proprietati) 
        {
            string[] token = proprietati.Split(',');

            _salary = int.Parse(token[7]);
            _lengthOfService = int.Parse(token[8]);
            _hoursOfService = int.Parse(token[9]);
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
            get { return _salary; }
            set { value = _salary; }
        }

        public int LengthOfService
        {
            get { return _lengthOfService; }
            set { _lengthOfService = value; }
        }

        public int HoursOfService
        {
            get { return _hoursOfService; }
            set { _hoursOfService = value; }
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
            text += "Hours Of Service " + _hoursOfService + "\n";
            text += "Lenght Of service" + _lengthOfService + "\n";
            text += "salary" + _salary + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.Type + "," + _salary + "," + _hoursOfService + "," +_lengthOfService;
        }
    }
}
