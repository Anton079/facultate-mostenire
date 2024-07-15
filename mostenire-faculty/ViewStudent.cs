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
        private ServiceAdministrator _administrator;
        private ServiceEmployee _employee;
        private ServicePerson _person;
        private ServiceStaff _staff;
        private ServiceFaculty _faculty;

        public ViewStudent(Student student)
        {
            this.student = student;
            _administrator = new ServiceAdministrator();
            _employee = new ServiceEmployee();
            _faculty = new ServiceFaculty();
            _staff = new ServiceStaff();
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
                string alegere = Console.ReadLine();

                switch (alegere)
                {

                }
            }
        }

        //public void AddEnrolmentInSchool()
        //{
        //    Console.WriteLine("Id ul a fost luat automat");
        //    int idStudent = student.Id;

        //    Console.WriteLine("Ce id are cursul la care vrei sa te inscrii?");
        //    int idCourse = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine("In ce data te inregistrezi?");
        //    int idCreateAt = Int32.Parse(Console.ReadLine());

        //    Enrolment Enrolment = new Enrolment(idStudent, idCourse, idCreateAt);

        //    _enrolmentService.AddEnrolment(Enrolment);

        //    _enrolmentService.SaveData();

        //    Console.WriteLine("Inregistrarea a fost reusita!");
        //}

        //public void AddBook()
        //{
        //    int idGenerat = _bookService.GenerateId();

        //    Console.WriteLine("Id ul tau a fost preluat automat");
        //    int idStudent = student.Id;

        //    Console.WriteLine("Ce nume are cartea?");
        //    string bookNewName = Console.ReadLine();

        //    Console.WriteLine("Cand a fost inchiriata cartea");
        //    int bookNewTime = Int32.Parse(Console.ReadLine());

        //    Book book = new Book(idGenerat, idStudent, bookNewName, bookNewTime);

        //    _bookService.AddBook(book);

        //    _bookService.SaveData();

        //    Console.WriteLine("Cartea a fost adauga !");
        //}

        //public void LeftACourse()
        //{
        //    Console.WriteLine("Ce id are cursul de la care vrei sa iesi?");
        //    int idCourse = Int32.Parse(Console.ReadLine());

        //    if (_courseService.FindCourseById(idCourse) != -1)
        //    {
        //        _enrolmentService.RemoveEnrolment(idCourse);
        //        Console.WriteLine("Ati fost scos de la curs");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nu a fost gasit curusl dorit");
        //    }
        //}
    }
}
