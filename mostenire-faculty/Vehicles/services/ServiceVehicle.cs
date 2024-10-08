﻿using mostenire_faculty.Vehicles.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty.Vehicles.services
{
    public class ServiceVehicle
    {
        private List<Vehicle> _vehicleList;

        public ServiceVehicle()
        {
            _vehicleList = new List<Vehicle>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string type = line.Split(',')[0];

                        switch (type)
                        {

                            case "Coupe": _vehicleList.Add(new Coupe(line)); break;

                            case "Suv": _vehicleList.Add(new Suv(line)); break;

                            case "Motorcycle": _vehicleList.Add(new Motorcycle(line)); break;

                            case "Sedan": _vehicleList.Add(new Sedan(line)); break;

                            default: break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "Vehicle");

            return file;
        }

        public string ToSaveAll()
        {
            string save = "";

            for (int i = 0; i < _vehicleList.Count; i++)
            {

                save += _vehicleList[i].ToSave();

                if (i < _vehicleList.Count - 1)
                {
                    save += "\n";
                }
            }

            return save;
        }


        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    sw.WriteLine(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //CRUD

        //SHOW
        public bool ShowVehiclesByCaroserieType(string caroserieType)
        {
            bool found = false;

            foreach (Vehicle vehicleWanted in _vehicleList)
            {
                if (vehicleWanted.Brand == caroserieType)
                {
                    found = true;
                    if (vehicleWanted is Sedan sedan)
                    {
                        Console.WriteLine(sedan.VehicleInfo());
                    }
                    else if (vehicleWanted is Suv suv)
                    {
                        Console.WriteLine(suv.VehicleInfo());
                    }
                    else if (vehicleWanted is Coupe coupe)
                    {
                        Console.WriteLine(coupe.VehicleInfo());
                    }
                    else if (vehicleWanted is Motorcycle motorcycle)
                    {
                        Console.WriteLine(motorcycle.VehicleInfo());
                    }
                }
            }

            return found;
        }


        public void ShowVehicles()
        {
            foreach (Vehicle showVehicle in _vehicleList)
            {
                Console.WriteLine(showVehicle.VehicleInfo());
            }
        }

        public void ShowVehicleByBrandAndHorsePower(string brand, int horsePower)
        {
            Vehicle vehicle = FindVehicleByBrandAndHorsePower(brand, horsePower);
            if (vehicle != null)
            {
                Console.WriteLine($"Vehiculul găsit:  Vehicul gasit:{vehicle.Brand} Id:{vehicle.Id} HorsePower:{vehicle.HorsePower} newton:{vehicle.Newton}");
            }
            else
            {
                Console.WriteLine("Vehiculul nu a putut fi găsit.");
            }
        }

        public void ShowBrands()
        {
            foreach (Vehicle vehicle in _vehicleList)
            {
                Console.WriteLine(vehicle.Brand);
            }
        }

        public void ShowOffRoad()
        {
            foreach (Vehicle offRoad in _vehicleList)
            {
                if (offRoad is Suv)
                {
                    Suv x = offRoad as Suv;
                    Console.WriteLine(x.OffRoad);
                }
            }
        }

        public void ShowMostUsedVehicle()
        {
            int MostUsed = ' ';
            string typeCar = " ";
            int newton = ' ';
            int horsePower = ' ';

            foreach (Vehicle vehicle in _vehicleList)
            {
                if(vehicle.Uses < MostUsed)
                {
                    MostUsed = vehicle.Uses;
                    typeCar = vehicle.Brand;
                    newton = vehicle.Newton;
                    horsePower = vehicle.HorsePower;
                }
            }
            Console.WriteLine($"Ce a mai uzata masina este {MostUsed} , {typeCar}, {newton} , {horsePower}");
        }

        //REST
        public bool AddVehicle(Vehicle newVehicle)
        {
            if (newVehicle is Suv)
            {
                Suv suv = newVehicle as Suv;
                _vehicleList.Add(newVehicle);
                SaveData();
                return true;
            }
            else if (newVehicle is Sedan)
            {
                Sedan sedan = newVehicle as Sedan;
                _vehicleList.Add(newVehicle);
                SaveData();
                return true;
            }
            else if (newVehicle is Coupe)
            {
                Coupe coupe = newVehicle as Coupe;
                _vehicleList.Add(newVehicle);
                SaveData();
                return true;
            }
            else if (newVehicle is Motorcycle)
            {
                Motorcycle motorcycle = newVehicle as Motorcycle;
                _vehicleList.Add(newVehicle);
                SaveData();
                return true;
            }
            return false;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindBrandById(id) != null)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool RemoveAVehicle(int idVehicle)
        {
            for(int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == idVehicle)
                {
                    _vehicleList.RemoveAt(i);
                    SaveData();
                    return true;
                }
            }
            return false;
        }

        //FIND
        public int FindVehicleByNewton(int newton)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Newton == newton)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool FindVehicleById(int id)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public string FindBrandById(int id)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id)
                {
                    return _vehicleList[i].Brand;
                }
            }
            return null;
        }

        public int FindIdByBrand(string brand)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Brand == brand)
                {
                    return _vehicleList[i].Id;
                }
            }
            return -1;
        }

        public Vehicle FindVehicleByBrandAndHorsePower(string brand, int horsePower)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Brand == brand && _vehicleList[i].HorsePower == horsePower)
                {
                    return _vehicleList[i];
                }
            }
            return null;
        }

        //EDIT
        public bool EditBrandById(int id, string brand)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id)
                {
                    _vehicleList[i].Brand = brand;

                    return true;
                }
            }
            return false;
        }

        public bool EditHorsePowerById(int id, int horsePower)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id)
                {
                    _vehicleList[i].HorsePower = horsePower;
                    SaveData();
                    return true;
                }
            }
            return false;
        }

        public bool EditNewtonById(int id, int newNewton)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id)
                {
                    _vehicleList[i].Newton = newNewton;
                    SaveData();
                    return true;
                }
            }
            return false;
        }

        public bool EditAirbagById(int id, int newAirbags)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id && _vehicleList[i] is Car)
                {
                    Car car = _vehicleList[i] as Car;
                    car.Airbags = newAirbags;
                    SaveData(); 
                    return true;
                }
            }
            return false; 
        }

        public bool EditTrunkById(int id, int newTrunk)
        {
            for (int i = 0; i < _vehicleList.Count; i++)
            {
                if (_vehicleList[i].Id == id && _vehicleList[i] is Car)
                {
                    Car car = _vehicleList[i] as Car;
                    car.Trunk = newTrunk;
                    SaveData();
                    return true;
                }
            }
            return false;
        }
    }
}
