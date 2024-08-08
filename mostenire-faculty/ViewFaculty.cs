using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewFaculty
    {
        private Faculty faculty;
        private ServicePerson _person;

        public ViewFaculty(Faculty faculty)
        {
            this.faculty = faculty;
            _person = new ServicePerson();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasa tasta 1 pentru a vedea cati studenti ai trecut");
            Console.WriteLine("Apasa tasta 2 pentru a vedea cati studenti nu ai trecut");
            Console.WriteLine("Apasa tasta 3 pentru ati schimba email ul");
            Console.WriteLine("Apasa tasta 4 pentru ati schimba parola");
            Console.WriteLine("Apasa tasta 5 pentru ati schimba nurmarul de telefon");
            Console.WriteLine("Apasa tasta 6 pentru a vedea ce salariu ai");
            Console.WriteLine("Apasa tasta 7 pentru a trimite un mesaj administratorului");
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
                        Console.WriteLine($"Numarul de studenti trecuti: {faculty.StudentsPast}");
                        break;

                    case "2":
                        Console.WriteLine($"Numarul de studenti nepromovati: {faculty.StudentsUnPassed}");
                        break;

                    case "3":
                        EditEmail();
                        break;

                    case "4":
                        EditPassword();
                        break;

                    case "5":
                        EditNumberPhone();
                        break;

                    case "6":
                        Console.WriteLine($"Salariul tau este: {faculty.Salary}");
                        break;

                    case "7":
                        SendMessageToAdmin();
                        break;
                }
            }
        }

        public void EditEmail()
        {
            int idWanted = faculty.Id;

            Console.WriteLine("Care sa fie noul email?");
            string newEmail = Console.ReadLine();

            _person.EditMailById(idWanted, newEmail);
            _person.SaveData();
            Console.WriteLine("Email-ul a fost actualizat!");
        }

        public void EditPassword()
        {
            int idWanted = faculty.Id;

            Console.WriteLine("Care sa fie noua parola?");
            string newPassword = Console.ReadLine();

            _person.EditPasswordById(idWanted, newPassword);
            _person.SaveData();
            Console.WriteLine("Parola a fost actualizata!");
        }

        public void EditNumberPhone()
        {
            int idWanted = faculty.Id;

            Console.WriteLine("Care sa fie noul numar de telefon?");
            int newPhone = Int32.Parse(Console.ReadLine());

            _person.EditPhoneNumber(idWanted, newPhone);
            Console.WriteLine("Numarul de telefon a fost actualizat!");
        }

        public void SendMessageToAdmin()
        {
            Console.WriteLine("Care sa fie mesajul?");
            string messageWant = Console.ReadLine();

            if (!string.IsNullOrEmpty(messageWant))
            {
                _person.NewMessageSend(faculty.Id, messageWant);
                Console.WriteLine("Mesajul a fost trimis administratorului!");
            }
            else
            {
                Console.WriteLine("Mesajul nu poate fi gol.");
            }
        }
    }
}
