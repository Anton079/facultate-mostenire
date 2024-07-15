﻿using System;
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

        public Staff(int id, string firstName, string lastName, string email, string password, int phoneNumber, string type, int hourOfService, int lenghtOfService, int salary, int invetoryMade, int buildingCleaned) : base(id, firstName, lastName, email, password, phoneNumber, type, hourOfService, lenghtOfService, salary)
        {
            _buildingCleaned = buildingCleaned;
            _invetoryMade = invetoryMade;
            base.Type = "Staff";
        }

        public Staff(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _buildingCleaned = int.Parse(token[10]);
            _invetoryMade = int.Parse(token[11]);
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

        public string SaffInfo()
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
            return base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," + base.Type + base.HoursOfService + "," + base.LengthOfService + "," + base.Salary;
        }
    }
}