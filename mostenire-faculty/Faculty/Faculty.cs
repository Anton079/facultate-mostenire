using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Faculty : Employee
    {
        private int _studentsPast;
        private string _studentsUnPassed;

        public Faculty(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int hourOfService, int lenghtOfService, int salary, int studentsPast, string studentsUnPassed) : base(id, firstName, lastName, email, password, phoneNumber, type, hourOfService, lenghtOfService, salary)
        {
            _studentsPast = studentsPast;
            _studentsUnPassed = studentsUnPassed;
            base.Type = "faculty";
        }

        public Faculty(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _studentsPast = int.Parse(token[10]);
            _studentsUnPassed = token[11];
        }

        public int StudentsPast
        {
            get { return _studentsPast; }
            set { _studentsPast = value; }
        }

        public string StudentsUnPassed
        {
            get { return _studentsUnPassed; }
            set { _studentsUnPassed = value; }
        }

        public string FacultyInfo()
        {
            string text = " ";
            text += "Type " + base.Type + "\n";
            text += "Id " + base.Id + "\n";
            text += "First name " + base.FirstName + "\n";
            text += "Last name " + base.LastName + "\n";
            text += "Email " + base.Email + "\n";
            text += "Password " + base.Password + "\n";
            text += "Phone number" + base.PhoneNumber + "\n";
            text += "Hours Of Service " + base.HoursOfService + "\n";
            text += "Lenght Of service" + base.LengthOfService + "\n";
            text += "salary" + base.Salary + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Type + ","+ base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.HoursOfService + "," + base.LengthOfService + "," + base.Salary;
        }
    }
}
