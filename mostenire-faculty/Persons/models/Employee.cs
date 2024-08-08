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

        public Employee(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int salary, int lengthOfService, int hourOfService) : base( type,  id,  firstName,  lastName,  email,  password,  phoneNumber)
        {
            _salary = salary;
            _lengthOfService = lengthOfService;
            _hoursOfService = hourOfService;
            base.Type = "Employee";
        }

        public Employee(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _salary = int.Parse(token[7]);
            _lengthOfService = int.Parse(token[8]);
            _hoursOfService = int.Parse(token[9]);
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
            text += "Type " + Type + "\n";
            text += "Id " + Id + "\n";
            text += "First name " + FirstName + "\n";
            text += "Last name " + LastName + "\n";
            text += "Email " + Email + "\n";
            text += "Password " + Password + "\n";
            text += "Phone number" + PhoneNumber + "\n";
            text += "salary" + _salary + "\n";
            text += "Lenght Of service" + _lengthOfService + "\n";
            text += "Hours Of Service " + _hoursOfService + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + _salary + "," + _lengthOfService + "," + _hoursOfService;
        }
    }
}
