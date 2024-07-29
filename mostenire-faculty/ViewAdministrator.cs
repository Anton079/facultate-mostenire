using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewAdministrator
    {
        private Administrator administrator;
        private ServicePerson _servicePerson;

        public ViewAdministrator(Administrator administrator)
        {
            this.administrator = administrator;
            _servicePerson = new ServicePerson();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a vedea toti studentii care se afla in facultate!");
            Console.WriteLine("Apasati tasta 2 pentru a cauta un student dupa Nume si prenume!");

            Console.WriteLine("Apasati tasta 3 pentru a vedea tot staff ul facultatii!");
            Console.WriteLine("Apasati tasta 4 pentru a cauta pe cineva din staff dupa Nume si prenume");

            Console.WriteLine("Apasati tsta 5 pentru a vedea tot faculty!");
            Console.WriteLine("Apasati tasta 6 pentru a cauta pe cineva din faculty dupa nume si prenume!");

            Console.WriteLine("Apasti tasta 7 pentru a sterge un student din facultate");
            Console.WriteLine("Apasti tasta 8 pentru a sterge un Staff din facultate");
            Console.WriteLine("Apasti tasta 9 pentru a sterge un Faculty din facultate");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                Meniu();
                string alegere= Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _servicePerson.ShowAllPerson();
                        break;

                    case "2":
                        FindPersonByNameAndLastName();
                        break;

                    case "3":
                        _servicePerson.ShowStaff();
                        break;

                    case "4":
                        FindPersonByNameAndLastName();
                        break;

                    case "5":
                        _servicePerson.ShowFaculty();
                        break;

                    case "6":
                        FindPersonByNameAndLastName();
                        break;

                    case "7":
                        RemoveStudent();
                        break;
                }
            }
        }

        public void FindPersonByNameAndLastName()
        {
            Console.WriteLine("Care este numele de familie?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Care este prenumele?");
            string lastName = Console.ReadLine();

            _servicePerson.ShowPersonByNameAndLastName(firstName, lastName);
        }

        public void RemoveStudent()
        {
            Console.WriteLine("Ce id are studentul?");
            int wantedId = Int32.Parse(Console.ReadLine());

            int studentId = _servicePerson.FindPersonById(wantedId);
            if (studentId != -1)
            {
                _servicePerson.RemovePerson(studentId);
                Console.WriteLine("Studentul a fost șters");
            }
            else
            {
                Console.WriteLine("Studentul nu a putut fi găsit");
            }
        }

        public void RemoveStaff()
        {
            Console.WriteLine("Ce id are staff ul?");
            int wantedId=  Int32.Parse(Console.ReadLine()) ;

            int staffId = _servicePerson.FindPersonById(wantedId);

            if(staffId != -1)
            {
                _servicePerson.RemovePerson(staffId);
                Console.WriteLine("Staff ul a fost sters!");
            }
            else
            {
                Console.WriteLine("staff ul nu a fost sters!");
            }
        }

        
    }
}
