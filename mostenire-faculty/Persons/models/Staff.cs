using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Staff : Employee
    {
        private int _invetoryMade;
        private int _buildingCleaned;

        public Staff(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int vehicleId, int salary, int lengthOfService, int hourOfService, int buildingCleaned, int invetoryMade) : base(type, id, firstName, lastName, email, password, phoneNumber, salary, lengthOfService, hourOfService, vehicleId)
        {
            _buildingCleaned = buildingCleaned;
            _invetoryMade = invetoryMade;
            base.Type = "Staff";
        }

        public Staff(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _buildingCleaned = int.Parse(token[11]);
            _invetoryMade = int.Parse(token[12]);
        }

        public int InvetoryMade
        {
            get { return _invetoryMade; }
            set { _invetoryMade = value; }
        }

        public int BuildingCleaned
        {
            get { return _buildingCleaned; }
            set { _buildingCleaned = value; }
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
            text += "BuildingCleanned " + BuildingCleaned + '\n';
            text += "Invetory Made " + InvetoryMade + '\n';
            return text;
        }

        public override string ToSave()
        {
            return base.Type + "," + base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + ","+ base.VehicleId + "," + base.Salary + "," + base.LengthOfService + "," + base.HoursOfService + "," + BuildingCleaned + "," + InvetoryMade;
        }
    }
}