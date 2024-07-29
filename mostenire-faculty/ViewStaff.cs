using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewStaff
    {
        private Staff staff;
        private ServicePerson _person;

        public ViewStaff(Staff staff)
        {
            this.staff = staff;
            _person = new ServicePerson();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasa tasta 1 pentru a vedea ce salariu ai!");
            Console.WriteLine("Apasa tasta 2 pentru a modifica parola!");
            Console.WriteLine("Apasa tasta 3 pentru a modifica nr de telefon!");
            Console.WriteLine("Apasa tasta 4 pentru a vedea de cate ori ai facut inventarul");
            Console.WriteLine("Apasa tasta 5 pentru a vedea de cate ori ai curatat cladirea");
            Console.WriteLine("Apasa tasta 6 pentru a trimite un mesaj administratorului!");
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
                        break;
                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;
                }
            }
        }

        

    }
}
