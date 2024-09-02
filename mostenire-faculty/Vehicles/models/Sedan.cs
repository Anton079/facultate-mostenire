using mostenire_faculty.Vehicles.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles
{
    public class Sedan : Car
    {
        private string _maiJoasa;
        private string _confortSporit;
        private string _spatiuRedus;

        public Sedan(string brand, int id, int horsePower, int newton, int uses, string steeringWheel, int airbags, int trunk, string maiJoasa, string confortSporit, string spatiuRedus) : base( brand,  id,  horsePower,  newton,  uses,  steeringWheel,  airbags,  trunk)
        {
            _maiJoasa = maiJoasa;
            _confortSporit = confortSporit;
            _spatiuRedus = spatiuRedus;
        }

        public Sedan(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _maiJoasa = token[8];
            _confortSporit = token[9];
            _spatiuRedus = token[10];
        }

        public string MaiJoasa
        {
            get { return _maiJoasa; }
            set { _maiJoasa = value; }
        }

        public string ConfortSporit
        {
            get { return _confortSporit; }
            set { _confortSporit = value; }
        }

        public string SpatiuRedus
        {
            get { return _spatiuRedus; }
            set { _spatiuRedus = value; }
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
            text += "Mai Joasa " + _maiJoasa + "\n";
            text += "Confort Sporit " + _confortSporit + "\n";
            text += "Spatiu Redus " + _spatiuRedus + "\n";
            return text;
        }

        public override string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Uses + "," + base.SteeringWheel + "," + base.Airbags + "," + base.Trunk + "," + _maiJoasa + "," + _confortSporit + "," + _spatiuRedus;
        }
    }
}
