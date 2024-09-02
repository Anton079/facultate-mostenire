using mostenire_faculty.Vehicles.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles
{
    public class Suv : Car
    {
        private string _capacitateMare;
        private string _maiInalt;
        private string _offRoad;

        public Suv(string brand, int id, int horsePower, int newton, int uses, string steeringWheel, int airbags, int trunk, string capacitateMare, string maiInalt, string offRoad) : base(brand, id, horsePower, newton, uses, steeringWheel, airbags, trunk)
        {
            _capacitateMare = capacitateMare;
            _maiInalt = maiInalt;
            _offRoad = offRoad;
        }

        public Suv(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _capacitateMare = token[8];
            _maiInalt = token[9];
            _offRoad = token[10];
        }

        public string CapacitateMare
        {
            get { return _capacitateMare; }
            set { _capacitateMare = value; }
        }

        public string MaiInalt
        {
            get { return _maiInalt; }
            set { _maiInalt = value; }
        }

        public string OffRoad
        {
            get { return _offRoad; }
            set { _offRoad = value; }
        }

        public override string VehicleInfo()
        {
            string text = " ";
            text += "Brand " + base.Brand + '\n';
            text += "Id " + base.Id + '\n';
            text += "Horse Power " + base.HorsePower + '\n';
            text += "Newton " + base.Newton + '\n';
            text += "Uses time " + base.Uses + '\n';
            text += "SteeringWheel " + base.SteeringWheel + "\n";
            text += "Airbags " + base.Airbags + "\n";
            text += "Trunk " + base.Trunk + "\n";
            text += "Capacitate " + _capacitateMare + "\n";
            text += "Mai inalt " + _maiInalt + "\n";
            text += "Off Road " + _offRoad + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Uses + "," + base.SteeringWheel + "," + base.Airbags + "," + base.Trunk + "," + _capacitateMare + "," + _maiInalt + "," + _offRoad;
        }
    }
}
