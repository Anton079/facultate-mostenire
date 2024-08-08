using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles.models
{
    public class Coupe : Car
    {
        private string _douaUsi;
        private string _designSportiv;
        private string _spatiuRedusPasageri;

        public Coupe(string brand, int id, int horsePower, int newton, int wheel, string steeringWheel, int airbags, int trunk, string douaUsi, string designSportiv, string spatiuRedusPasageri) : base( brand,  id,  horsePower,  newton,  wheel,  steeringWheel,  airbags, trunk)
        {
            _douaUsi = douaUsi;
            _designSportiv = designSportiv;
            _spatiuRedusPasageri = spatiuRedusPasageri;
        }

        public Coupe(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _douaUsi = token[8];
            _designSportiv = token[9];
            _spatiuRedusPasageri= token[10];
        }

        public string DouaUsi
        {
            get { return _douaUsi;}
            set { _douaUsi = value;}
        }

        public string DesignSportiv
        {
            get { return _designSportiv;}
            set { _designSportiv = value;}
        }

        public string SpatiuRedusPasageri
        {
            get { return _spatiuRedusPasageri; }
            set { _spatiuRedusPasageri = value;}
        }

        public string CopueInfo()
        {
            string text = " ";
            text += "Brand " + base.Brand + '\n';
            text += "Id " + base.Id + '\n';
            text += "Horse Power " + base.HorsePower + '\n';
            text += "Newton " + base.Newton + '\n';
            text += "Wheel " + base.Wheel + '\n';
            text += "SteeringWheel " + base.SteeringWheel + "\n";
            text += "Airbags " + base.Airbags + "\n";
            text += "Trunk " + base.Trunk + "\n";
            text += "Doua usi " + _douaUsi + "\n";
            text += "Design sportiv " + _designSportiv + "\n";
            text += "Spatiu redus pasageri " + _spatiuRedusPasageri + "\n";
            return text;
        }

        public string ToSave()
        {
            return base.Brand + "," + base.Id + "," + base.HorsePower + "," + base.Newton + "," + base.Wheel + "," + base.SteeringWheel + "," + base.Airbags + "," + base.Trunk + "," + _douaUsi + "," + _designSportiv + "," + _spatiuRedusPasageri;
        }
    }
}
