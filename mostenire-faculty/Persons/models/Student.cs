﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mostenire_faculty
{
    public class Student : Person
    {
        private int _schoolYear;
        private int _studentdAge;
        private int _remainingExams;

        public Student(string type, int id, string firstName, string lastName, string email, string password, int phoneNumber, int vehicleId, int schoolYear, int studentAge, int remainingExams) : base( type,  id,  firstName,  lastName,  email,  password,  phoneNumber, vehicleId)
        {
            _schoolYear = schoolYear;
            _studentdAge = studentAge;
            _remainingExams = remainingExams;
            base.Type = "Student";
        }

        public Student(string prorpeitati) : base(prorpeitati)
        {
            string[] token = prorpeitati.Split(',');

            _schoolYear = int.Parse(token[8]);
            _studentdAge = int.Parse(token[9]);
            _remainingExams = int.Parse(token[10]);
        }

        public int SchoolYear
        {
            get { return _schoolYear; }
            set { _schoolYear = value; }
        }

        public int StudentdAge
        {
            get { return _studentdAge; }
            set { _studentdAge = value; }
        }

        public int RemainingExams
        {
            get { return _remainingExams; }
            set { _remainingExams = value; }
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
            text += "vehicle id " + base.VehicleId + "\n";
            text += "School Year " + _schoolYear + "\n";
            text += "Student age " + _studentdAge + "\n";
            text += "RemainingExams " + _remainingExams + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Type + "," +base.Id + "," + base.FirstName + "," + base.LastName + "," + base.Email + "," + base.Password + "," + base.PhoneNumber + "," +  base.VehicleId + "," +_schoolYear + "," + _studentdAge + "," + _remainingExams;
        }

        public override int GetSalary()
        {
            return -1;
        }
    }
}
