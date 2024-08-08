﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles.models
{
    public class Motorcycle : Vehicle
    {
        private string _handleBars;
        private string _kickStand;
        private string _cluchLever;

        public Motorcycle(string brand, int id, int horsePower, int newton, int wheel, string handleBars, string kickStand, string cluchLever): base(brand,id,horsePower,newton,wheel)
        {
            _handleBars = handleBars;
            _kickStand = kickStand;
            _cluchLever = cluchLever;
        }

        public Motorcycle(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _handleBars = token[5];
            _kickStand= token[6];
            _cluchLever = token[7];
        }

        public string HandleBars
        {
            get { return _handleBars; }
            set { _handleBars = value; }
        }

        public string KickStand
        {
            get { return _kickStand; }
            set { _kickStand = value; }
        }

        public string CluchLever
        {
            get { return _cluchLever; }
            set { _cluchLever = value;}
        }

        public string MotorcycleInfo()
        {
            string text = " ";
            text += "Brand " + base.Brand + '\n';
            text += "Id " + base.Id + '\n';
            text += "Horse Power " + base.HorsePower + '\n';
            text += "Newton " + base.Newton + '\n';
            text += "Wheel " + base.Wheel + '\n';
            text += "HandleBard " + _handleBars + "\n";
            text += "KickStand " + _kickStand + "\n";
            text += "CluchLver " + _cluchLever + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Wheel + "," + _handleBars + "," + _kickStand + "," + _cluchLever;
        }
    }
}
