using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Person
    {
        private string _type;
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private int _phoneNumber;
        private int _vehicleId;

       

        public Person(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _type = token[0];
            _id = int.Parse(token[1]);
            _firstName = token[2];
            _lastName = token[3];
            _email = token[4];
            _password = token[5];
            _phoneNumber = int.Parse(token[6]);
            _vehicleId = int.Parse(token[7]);
        }

        public Person(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int vehicleId)
        {
            _type = type;
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _phoneNumber = phoneNumber;
            _vehicleId = vehicleId;
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public int VehicleId
        {
            get { return _vehicleId; }
            set { _vehicleId = value; }
        }

        public virtual string PersonInfo()
        {
            string text = " ";
            text += "Type " + _type + "\n";
            text += "Id " + _id + "\n";
            text += "First name " + _firstName + "\n";
            text += "Last name " + _lastName + "\n";
            text += "Email " + _email + "\n";
            text += "Password " + _password + "\n";
            text += "Phone Numer " + _phoneNumber + "\n";
            text += "vehicle id " + _vehicleId + "\n";
            return text;
        }

        public virtual string ToSave()
        {
            return _type + "," +_id + "," + _firstName + "," + _lastName + "," + _email + "," + _password + "," + _phoneNumber + "," + _vehicleId;
        }


        public virtual  int  GetSalary()
        {
            return -1;
        }

        
    }
}
