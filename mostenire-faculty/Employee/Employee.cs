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

        public Employee(int id, string firstName, string lastName, string email, string password, int phoneNumber, string type, int hourOfService, int salary, int lengthOfService) : base(id, firstName, lastName, email, password, phoneNumber, type)
        {
            _salary = salary;
            _lengthOfService = lengthOfService;
            _hoursOfService = hourOfService;
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
            text += "Hours Of Service " + _hoursOfService + "\n";
            text += "Lenght Of service" + _lengthOfService + "\n";
            text += "salary" + _salary + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + FirstName + "," + LastName + "," + Email + "," + Password + "," + PhoneNumber + "," + Type + "," + _salary + "," + _hoursOfService + "," + _lengthOfService;
        }
    }
}
