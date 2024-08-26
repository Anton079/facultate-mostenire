using mostenire_faculty.Vehicles;
using mostenire_faculty.Vehicles.models;
using mostenire_faculty.Vehicles.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class View
    {
        private ServicePerson servicePerson;
        private ServiceVehicle serviceVehicle;

        
        public View(ServicePerson servicePerson, ServiceVehicle serviceVehicle)
        {
            this.servicePerson = servicePerson;
            this.serviceVehicle = serviceVehicle;
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a vedea toate masinile");
            Console.WriteLine("Apasati tasta 2 pentru a gasi persoana dupa id ul masinii");
            Console.WriteLine("Apasati tasta 3 pentru a vedea ce-a mai frecventata masina");
            Console.WriteLine("Apasati tasta 4 pentru a sterge o masina");
            Console.WriteLine("Apasati tasta 5 pentru a edita vehiculul id");
            Console.WriteLine("Apasati tasta 6 pentru a edita tuturor studentilor un vehicul");
            Console.WriteLine("Apasati tasta 7 pentru a adauga un brand unei persoane la vehicul");
            Console.WriteLine("Apasati tasta 8 pentru a vedea toate masinile dupa un tip de caroserie");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        serviceVehicle.ShowVehicles();
                        break;

                    case "2":
                        ShowPersonByIdvehicle();
                        break;

                    case "3":
                        serviceVehicle.ShowMostUsedVehicle();
                        break;

                    case "4":
                        RemoveVehicle();
                        break;

                    case "5":
                        EditAvehicleIdFromAPerson();
                        break;

                    case "6":
                        EditAllStudentsAVehicle();
                        break;

                    case "7":
                        AddVehicle();
                        break;

                    case "8":
                        ShowVehicleByType();
                        break;
                }
            }

        }

        public void ShowVehicleByType()
        {
            Console.WriteLine("Ce caroserie vrei sa vezi?");
            string type = Console.ReadLine();

            if (serviceVehicle.ShowVehiclesByCaroserieType(type))
            {
                Console.WriteLine($"Toate mașinile cu tipul de caroserie '{type}' sunt afișate mai sus.");
            }
            else
            {
                Console.WriteLine($"Nu s-au găsit mașini cu tipul de caroserie '{type}'.");
            }
        }

        public void ShowPersonByIdvehicle()
        {
            Console.WriteLine("Ce id are vehiculul persoanei respective");
            int idWanted = Int32.Parse(Console.ReadLine());

            servicePerson.ShowPersonByIdVehicle(idWanted);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Ce id are masina pe care vrei sa o stergi");
            int idWanted = Int32.Parse(Console.ReadLine());

            if (serviceVehicle.FindVehicleById(idWanted))
            {
                Console.WriteLine($"Masina cu id-ul {idWanted} a fost stearsa");
                serviceVehicle.RemoveAVehicle(idWanted);
            }
            else
            {
                Console.WriteLine($"Masina cu id-ul {idWanted} nu a putut fi gasita!");
            }
            
        }

        public void EditAvehicleIdFromAPerson()
        {
            Console.WriteLine("Ce id are persoana caruia doriti sa ii editati vehiculul?");
            int idPerson = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce id are masina cu care doriti sa o modificati cu actuala?");
            int idVehicle = int.Parse(Console.ReadLine());

            if(servicePerson.EditIdVehicle(idPerson, idVehicle))
            {
                Console.WriteLine("Masina a putut fi modificata");
            }
            else
            {
                Console.WriteLine("Masina nu a putut fi modificata");
            }
            servicePerson.SaveData();
        }

        public void EditAllStudentsAVehicle()
        {
            Console.WriteLine("Ce id are vehiculul pe care vreti sa il puneti in locul la actualele vehicule?");
            int idVehicle = Int32.Parse(Console.ReadLine());

            if (servicePerson.EditAllStudentAVehicle(idVehicle))
            {
                Console.WriteLine("Editul a fost reusit!");
            }
            else
            {
                Console.WriteLine("Editul nu a reusit!");
            }
            servicePerson.SaveData();


        }

        public void AddVehicle()
        {
            Console.WriteLine("Ce id are persoana care doreste o masina?");
            int idPerson = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce masina doreste persoana dintre Coupe, Motorcycle, Suv si sedan? ");
            string wantedVehicle = Console.ReadLine();

            if(wantedVehicle is Vehicle)
            {
                servicePerson.EditIdVehicle(idPerson, serviceVehicle.FindIdByBrand(wantedVehicle));
                servicePerson.SaveData();
            }
            else
            {
                Console.WriteLine("Masina nu a fost gasita!");
            }
        }
    }
}
