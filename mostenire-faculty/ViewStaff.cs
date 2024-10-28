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
                        _person.ShowSalary();
                        break;

                    case "2":
                        EditPassword();
                        break;

                    case "3":
                        EditNumberPhone();
                        break;

                    case "4":
                        _person.ShowCuratenie();
                        break;

                    case "5":
                        _person.ShowCuratenie();
                        break;

                    case "6":
                        SendMessageToAdmin();
                        break;
                }
            }
        }

        public void EditPassword()
        {
            int idWanted = staff.Id;

            Console.WriteLine("Care sa fie noua problema!");
            string newPassword = Console.ReadLine();

            _person.EditPasswordById(idWanted, newPassword);
        }

        public void EditNumberPhone()
        {
            int idWanted = staff.Id;

            Console.WriteLine("Care sa fie noul numar de telefon!");
            string newPhone = Console.ReadLine();

            _person.EditPasswordById(idWanted, newPhone);
        }

        public void SendMessageToAdmin()
        {
            Console.WriteLine("Care să fie mesajul?");
            string messageWant = Console.ReadLine();

            Console.WriteLine("Introduceți ID-ul administratorului:");
            int idWanted = Int32.Parse(Console.ReadLine());

            if (messageWant != null && idWanted != -1)
            {
                if (_person.NewMessageSend(idWanted, messageWant))
                {
                    Console.WriteLine("Mesajul a fost trimis cu succes!");
                }
                else
                {
                    Console.WriteLine("Mesajul nu s-a putut trimite! Administratorul nu a fost găsit sau altă eroare.");
                }
            }
            else
            {
                Console.WriteLine("Mesajul sau ID-ul administratorului nu sunt valide!");
            }
        }


    }
}
