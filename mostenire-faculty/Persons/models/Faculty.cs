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
        private int _studentsUnPassed;

        public Faculty(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int vehicleId , int salary, int lengthOfService, int hourOfService, int studentsPast, int studentsUnPassed) : base( type,  id,  firstName,  lastName,  email,  password,  phoneNumber,  salary,  lengthOfService,  hourOfService, vehicleId)
        {
            _studentsPast = studentsPast;
            _studentsUnPassed = studentsUnPassed;
            base.Type = "Faculty";
        }

        public Faculty(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _studentsPast = int.Parse(token[11]);
            _studentsUnPassed = int.Parse(token[12]);
        }

        public int StudentsPast
        {
            get { return _studentsPast; }
            set { _studentsPast = value; }
        }

        public int StudentsUnPassed
        {
            get { return _studentsUnPassed; }
            set { _studentsUnPassed = value; }
        }

        public override string PersonInfo()
        {
            string text = " ";
            text += "Type " + base.Type + "\n";
            text += "Id " + base.Id + "\n";
            text += "First name " + base.FirstName + "\n";
            text += "Last name " + base.LastName + "\n";
            text += "Email " + base.Email + "\n";
            text += "Password " + base.Password + "\n";
            text += "Phone number" + base.PhoneNumber + "\n";
            text += "vehicle Id " + base.VehicleId + "\n";
            text += "salary" + base.Salary + "\n";
            text += "Lenght Of service" + base.LengthOfService + "\n";
            text += "Hours Of Service " + base.HoursOfService + "\n";
            text += "Student past " + StudentsPast + "\n";
            text += "StudentPassed " + StudentsUnPassed + '\n';
            return text;
        }

        public override string ToSave()
        {
            return base.Type + ","+ base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.VehicleId + "," + base.Salary + "," + base.LengthOfService + "," + base.HoursOfService + "," + StudentsPast + "," + StudentsUnPassed;
        }

        public override int GetSalary()
        {
            return Salary;
        }
    }
}
