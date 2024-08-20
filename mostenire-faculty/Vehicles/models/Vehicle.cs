using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class Vehicle
    {
        private string _brand;
        private int _id;
        private int _horsePower;
        private int _newton;
        private int _uses;

        public Vehicle(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _brand = token[0];
            _id = int.Parse(token[1]);
            _horsePower = int.Parse(token[2]);
            _newton = int.Parse(token[3]);
            _uses = int.Parse(token[4]);
        }

        public Vehicle(string brand, int id, int horsePower, int newton, int wheel)
        {
            _brand = brand;
            _id = id;
            _horsePower = horsePower;
            _newton = newton;
            _uses = wheel;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int HorsePower
        {
            get { return _horsePower; }
            set { _horsePower = value; }
        }

        public int Newton
        {
            get { return _newton; }
            set { _newton = value; }
        }

        public int Uses
        {
            get { return _uses; }
            set { _uses = value; }
        }

        public string CarInfo()
        {
            string text = " ";
            text += "Brand " + _brand + '\n';
            text += "Id " + _id + '\n';
            text += "Horse Power " + _horsePower + '\n';
            text += "Newton " + _newton + '\n';
            text += "uses time" + _uses + '\n';
            return text;
        }

        public string ToSave()
        {
            return _brand + "," + _id + "," + _horsePower + "," + _newton + "," + _uses;
        }

    }
}
