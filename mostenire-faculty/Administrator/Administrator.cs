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
        private int _problemsSolved;
        private string _messagesReceived;

        public Administrator(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int salary, int lengthOfService, int hourOfService, int organizedEvents, int problemsSolved, string messagesReceived) : base( type,  id,  firstName,  lastName,  email,  password,  phoneNumber,  salary,  lengthOfService,  hourOfService)
        {
            _organizedEvents = organizedEvents;
            _problemsSolved = problemsSolved;
            _messagesReceived = messagesReceived;
            Type = "Administrator";
        }

        public Administrator(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _organizedEvents = int.Parse(token[10]);
            _problemsSolved = int.Parse(token[11]);
            _messagesReceived = token[12];
        }

        public int OrganizedEvents
        {
            get { return _organizedEvents; }
            set { _organizedEvents = value; }
        }

        public int ProblemsSolved
        {
            get { return _problemsSolved; }
            set { _problemsSolved = value; }
        }

        public string MessagesReceived
        {
            get { return _messagesReceived; }
            set { _messagesReceived = value; }
        }

        public string AdministratorInfo()
        {
            string text = " ";
            text += "Type " + Type + "\n";
            text += "Id " + Id + "\n";
            text += "First name " + FirstName + "\n";
            text += "Last name " + LastName + "\n";
            text += "Email " + Email + "\n";
            text += "Password " + Password + "\n";
            text += "Phone number" + PhoneNumber + "\n";
            text += "salary" + Salary + "\n";
            text += "Lenght Of service" + LengthOfService + "\n";
            text += "Hours Of Service " + HoursOfService + "\n";
            text += "Organized Event " + OrganizedEvents + "\n";
            text += "Problem Solved " + ProblemsSolved + "\n";
            text += "MessagesRecived " + MessagesReceived + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.Salary + "," + base.LengthOfService + "," + base.HoursOfService + "," + OrganizedEvents + ","+ ProblemsSolved + "," + MessagesReceived;
        }
    }
}