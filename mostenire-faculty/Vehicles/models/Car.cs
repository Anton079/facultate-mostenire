using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles.models
{
    public class Car : Vehicle
    {
        private string _steeringWheel;
        private int _airbags;
        private int _trunk;
      

        public Car(string brand, int id, int horsePower, int newton, int uses, string steeringWheel, int airbags, int trunk): base( brand,  id,  horsePower,  newton, uses)
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

        public override string VehicleInfo()
        {
            string text = " ";
            text += "Brand " + base.Brand + '\n';
            text += "Id " + base.Id + '\n';
            text += "Horse Power " + base.HorsePower + '\n';
            text += "Newton " + base.Newton + '\n';
            text += "uses time" + base.Uses + '\n';
            text += "SteeringWheel " + _steeringWheel + "\n";
            text += "Airbags " + _airbags + "\n";
            text += "Trunk " + _trunk + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Uses + "," + _steeringWheel + "," + _airbags + "," + _trunk;
        }
    }
}
