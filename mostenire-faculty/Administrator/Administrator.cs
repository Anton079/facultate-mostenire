using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Administrator : Employee
    {
        private int _organizedEvents;
        private string _problemsSolved;

        public Administrator(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int hourOfService, int lenghtOfService, int salary, int organizedEvents, string problemsSolved) : base(id, firstName, lastName, email, password, phoneNumber, type, hourOfService, lenghtOfService, salary)
        {
            _organizedEvents = organizedEvents;
            _problemsSolved = problemsSolved;
            Type = "Administrator";
        }

        public Administrator(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _organizedEvents = int.Parse(token[10]);
            _problemsSolved = token[11];
        }

        public int OrganizedEvents
        {
            get { return _organizedEvents; }
            set { _organizedEvents = value; }
        }

        public string ProblemsSolved
        {
            get { return _problemsSolved; }
            set { _problemsSolved = value; }
        }

        public string AdminInfo()
        {
            string text = " ";
            text += "Type " + Type + "\n";
            text += "Id " + Id + "\n";
            text += "First name " + FirstName + "\n";
            text += "Last name " + LastName + "\n";
            text += "Email " + Email + "\n";
            text += "Password " + Password + "\n";
            text += "Phone number" + PhoneNumber + "\n";
            text += "Hours Of Service " + HoursOfService + "\n";
            text += "Lenght Of service" + LengthOfService + "\n";
            text += "salary" + Salary + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + FirstName + "," + LastName + "," + Email + "," + Password + "," + PhoneNumber + "," + Type + HoursOfService + "," + LengthOfService + "," + Salary;
        }
    }
}
