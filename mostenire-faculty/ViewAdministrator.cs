using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewAdministrator
    {
        private Administrator administrator;
        private ServiceEmployee _employee;
        private ServicePerson _person;
        private ServiceStaff _staff;
        private ServiceStudent _student;
        private ServiceFaculty _faculty;

        public ViewAdministrator(Administrator administrator)
        {
            this.administrator = administrator;
            _employee = new ServiceEmployee();
            _faculty = new ServiceFaculty();
            _staff = new ServiceStaff();
            _student = new ServiceStudent();
            _person = new ServicePerson();
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
                        ShowStundeti();
                        break;

                    case "2":
                        FindStudentByFirstAndLastName();
                        break;

                    case "3":
                        ShowStaff();
                        break;

                    case "4":
                        FindStaffByFirstAndLastName();
                        break;

                    case "5":
                        ShowFaculty();
                        break;

                    case "6":
                        FindFacultyByFirstAndLastName();
                        break;

                    case "7":
                        RemoveStudent();
                        break;
                }
            }
        }

        public void ShowStundeti()
        {
            _student.AfisareStudents();
        }

        public void FindStudentByFirstAndLastName()
        {
            Console.WriteLine("Care este numele de familie?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Care este prenumele?");
            string lastName = Console.ReadLine();

            _student.FindStudentByFirstAndLastName(firstName, lastName);

            _student.AfisareStudentByNameAndLastName(firstName, lastName);
        }

        public void ShowStaff()
        {
            _staff.AfisareStaff();
        }

        public void FindStaffByFirstAndLastName()
        {
            Console.WriteLine("Care este numele de familie?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Care este prenumele?");
            string lastName = Console.ReadLine();

            _staff.FindStaffByFirstAndLastName(firstName, lastName);

            _staff.AfisareStaffByNameAndLastName(firstName, lastName);
        }

        public void ShowFaculty()
        {
            _faculty.AfisareFaculty();
        }

        public void FindFacultyByFirstAndLastName()
        {
            Console.WriteLine("Care este numele de familie?");
            string firstName = Console.ReadLine();

            Console.WriteLine("Care este prenumele?");
            string lastName = Console.ReadLine();

            _faculty.FindFacultyByFirstAndLastName(firstName, lastName);

            _faculty.AfisareFacultyByNameAndLastName(firstName, lastName);
        }

        public void RemoveStudent()
        {
            Console.WriteLine("Ce id are studentul?");
            int wantedId = Int32.Parse(Console.ReadLine());

            int studentId = _student.FindStudentById(wantedId);
            if (studentId != -1)
            {
                _student.RemoveStudentById(studentId);
                Console.WriteLine("Studentul a fost șters");
            }
            else
            {
                Console.WriteLine("Studentul nu a putut fi găsit");
            }
        }
    }
}
