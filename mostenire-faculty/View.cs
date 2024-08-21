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
        }

        public void play()
        {
            bool running = true;
            string alegere = Console.ReadLine();

            switch(alegere)
            {
                case "1":
                    serviceVehicle.ShowVehicle();
                    break;

                case "2":
                    ShowPersonByIdvehicle();
                    break;

                case "3":
                    serviceVehicle.ShowMostUsedVehicle();
                    break;

                case "4":
                    RemoveAVehicle();
                    break;

                case "5":
                    EditAvehicleIdFromAPerson();
                    break;

                case "6":
                    EditAllStudentsAVehicle();
                    break;
            }
        }

        public void ShowPersonByIdvehicle()
        {
            Console.WriteLine("Ce id are vehiculul pe care il cauti");
            int idWanted = Int32.Parse(Console.ReadLine());

            servicePerson.ShowPersonByIdVehicle(idWanted);
        }

        public void RemoveAVehicle()
        {
            Console.WriteLine("Ce id are masina vrei sa stergi");
            int idWanted = Int32.Parse(Console.ReadLine());

            if (serviceVehicle.RemoveVehicle(idWanted))
            {
                Console.WriteLine("Masina a fost stearsa");
            }
            else
            {
                Console.WriteLine("Masina nu a putut fi gasita!");
            }
            
        }

        public void EditAvehicleIdFromAPerson()
        {
            Console.WriteLine("Ce id are persoana caruia doriti sa ii editati vehiculul?");
            int idPerson = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce id are masina pe care doriti sa o editati");
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
            Console.WriteLine("Ce id are vehiculul pe care vreti sa il puneti in loc la actualul vehicul?");
            int idVehicle = Int32.Parse(Console.ReadLine());

            if (servicePerson.EditAllStudentAVehicle(idVehicle))
            {
                Console.WriteLine("Editul a fost reusit!");
            }
            else
            {
                Console.WriteLine("Editul nu a reusit!");
            }


        }
    }
}
