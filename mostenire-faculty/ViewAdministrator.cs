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
                        //_servicePerson.ShowPersonByType("Student");
                        break;

                    case "2":
                        FindPersonByNameAndLastName();
                        break;

                    case "3":
                        //_servicePerson.ShowPersonByType("Staff");
                        break;

                    case "4":
                        FindPersonByNameAndLastName();
                        break;

                    case "5":
                        //_servicePerson.ShowPersonByType("Faculty");
                        break;

                    case "6":
                        FindPersonByNameAndLastName();
                        break;

                    case "7":
                        RemoveStudent();
                        break;

                    case "8":
                        RemoveStaff();
                        break;

                    case "9":
                        RemoveFaculty();
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
            Console.WriteLine("Ce ID are studentul?");
            int wantedId = Int32.Parse(Console.ReadLine());

            var person = _servicePerson.FindPersonById(wantedId);

            if (person != null)
            {
                if (person is Student)
                {
                    _servicePerson.RemovePerson(wantedId);
                    Console.WriteLine("Studentul a fost șters");
                }
                else
                {
                    Console.WriteLine("ID-ul nu se referă la un Student!");
                }
            }
            else
            {
                Console.WriteLine("Studentul nu a putut fi găsit");
            }
        }

        public void RemoveStaff()
        {
            Console.WriteLine("Ce ID are staff-ul?");
            int wantedId = Int32.Parse(Console.ReadLine());

            var person = _servicePerson.FindPersonById(wantedId);

            if (person != null)
            {
                if (person is Staff)
                {
                    _servicePerson.RemovePerson(wantedId);
                    Console.WriteLine("Staff-ul a fost șters!");
                }
                else
                {
                    Console.WriteLine("ID-ul nu se referă la un Staff!");
                }
            }
            else
            {
                Console.WriteLine("Staff-ul nu a fost găsit");
            }
        }

        public void RemoveFaculty()
        {
            Console.WriteLine("Ce ID are faculty-ul?");
            int wantedId = Int32.Parse(Console.ReadLine());

            var person = _servicePerson.FindPersonById(wantedId);

            if (person != null)
            {
                if (person is Faculty)
                {
                    _servicePerson.RemovePerson(wantedId); 
                    Console.WriteLine("Faculty-ul a fost sters!");
                }
                else
                {
                    Console.WriteLine("ID-ul nu se referă la un Faculty!");
                }
            }
            else
            {
                Console.WriteLine("Persoana nu a fost găsită!");
            }
        }


    }
}
