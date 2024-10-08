﻿using System;

namespace mostenire_faculty
{
    public class ViewStudent
    {
        private Student student;
        private ServicePerson _personService;

        public ViewStudent(Student student, ServicePerson personService)
        {
            this.student = student;
            _personService = personService;
        }

        public void Meniu()
        {
            Console.WriteLine("Apasă tasta 1 pentru a modifica email-ul!");
            Console.WriteLine("Apasă tasta 2 pentru a modifica parola!");
            Console.WriteLine("Apasă tasta 3 pentru a vedea ce an ești la facultate");
            Console.WriteLine("Apasă tasta 4 pentru a vedea câte examene mai ai de dat!");
            Console.WriteLine("Apasa tasta 5 pentru a raporta o problema la administrator");
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

                    case "3":
                        ShowSchoolYear();
                        break;

                    case "4":
                        ShowRemainingExams();
                        break;

                    case "5":
                        ModificaEmail();
                        break;
                }
            }
        }

        public void ModificaEmail()
        {
            Console.WriteLine("Introdu noul email:");
            string newEmail = Console.ReadLine();

            if (_personService.EditMailById(student.Id, newEmail))
            {
                student.Email = newEmail;
                Console.WriteLine("Email modificat cu succes!");
            }
            else
            {
                Console.WriteLine("Email-ul nu a putut fi modificat.");
            }
        }

        public void ModificaParola()
        {
            Console.WriteLine("Introdu noua parolă:");
            string newPassword = Console.ReadLine();

            if (_personService.EditPasswordById(student.Id, newPassword))
            {
                student.Password = newPassword;
                Console.WriteLine("Parola modificată cu succes!");
            }
            else
            {
                Console.WriteLine("Parola nu a putut fi modificată.");
            }
        }

        public void ShowSchoolYear()
        {
            Console.WriteLine($"Anul școlar: {student.SchoolYear}");
        }

        public void ShowRemainingExams()
        {
            Console.WriteLine($"Examene rămase: {student.RemainingExams}");
        }

        public void SendMessageToAdmin()
        {
            Console.WriteLine("Ce mesaj vrei sa trimiti!");
            string msgToSend = Console.ReadLine();

            Console.WriteLine("Ce id are adminul caruia vrei sa ii trimiti mesajul?");
            int idAdmin = Int32.Parse(Console.ReadLine());

            if (msgToSend != null)
            {
                _personService.NewMessageSend(idAdmin ,msgToSend);
            }
            else
            {
                Console.WriteLine("Mesaul este gol, trebuie sa introduci ceva pentru a trimite!");
            }
        }
    }
}
