using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles.models
{
    public class Car : Vehicle
    {
        private string _steeringWheel;
        private int _airbags;
        private int _trunk;

        public Car(string brand, int id, int horsePower, int newton, int wheel, string steeringWheel, int airbags, int trunk): base( brand,  id,  horsePower,  newton, wheel)
        {
            _steeringWheel = steeringWheel;
            _airbags = airbags;
            _trunk = trunk;
        }

        public Car(string proprietati) : base (proprietati)
        {
            string[] token = proprietati.Split(',');

            _steeringWheel = token[5];
            _airbags = int.Parse(token[6]);
            _trunk = int.Parse(token[7]);
        }

        public string SteeringWheel
        {
            get { return _steeringWheel; }
            set { _steeringWheel = value; }
        }

        public int Airbags
        {
            get { return _airbags; }
            set { _airbags = value; }
        }

        public int Trunk
        {
            get { return _trunk; }
            set { _trunk = value; }
        }

        public string CarInfo()
        {
            string text = " ";
            text += "Brand " + base.Brand + '\n';
            text += "Id " + base.Id + '\n';
            text += "Horse Power " + base.HorsePower + '\n';
            text += "Newton " + base.Newton + '\n';
            text += "Wheel " + base.Wheel + '\n';
            text += "SteeringWheel " + _steeringWheel + "\n";
            text += "Airbags " + _airbags + "\n";
            text += "Trunk " + _trunk + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Wheel + "," + _steeringWheel + "," + _airbags + "," + _trunk;
        }
    }
}
