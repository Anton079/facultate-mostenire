using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewStudent
    {
        private Student student;
        private ServicePerson _personService;

        public ViewStudent(Student student)
        {
            this.student = student;
            _personService = new ServicePerson();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasa taasta 1 pentru ati modifica mail ul!");
            Console.WriteLine("Apasa tasta 2 pentru ati modifica parola!");
            Console.WriteLine("Apasati tasta 3 pentru a vedea ce an esti la facultate");
            Console.WriteLine("Apasati tasta 4 pentru a vedea ce ");
            Console.WriteLine("");
            Console.WriteLine("");
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
                        ModificaEmail();
                        break;
                    case "2":
                        ModificaParola();
                        break;
                }
            }
        }

        private void ModificaEmail()
        {
            Console.WriteLine("Introdu noul email:");
            string newEmail = Console.ReadLine();
            
            
            Console.WriteLine("Email modificat cu succes!");
        }

        private void ModificaParola()
        {
            Console.WriteLine("Introdu noua parola:");
            string newPassword = Console.ReadLine();
            
            Console.WriteLine("Parola modificata cu succes!");
        }




    }
}
