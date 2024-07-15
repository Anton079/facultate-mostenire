using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewAdministrator
    {
        private ServiceAdministrator _administrator;
        private ServiceEmployee _employee;
        private ServicePerson _person;
        private ServiceStaff _staff;
        private ServiceStudent _student;
        private ServiceFaculty _faculty;

        public ViewAdministrator()
        {
            _administrator = new ServiceAdministrator();
            _employee = new ServiceEmployee();
            _faculty = new ServiceFaculty();
            _staff = new ServiceStaff();
            _student = new ServiceStudent();
            _person = new ServicePerson();
        }

        public void Meniu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
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

                }
            }
        }
    }
}
