using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ViewLogin
    {
        private ServiceAdministrator _administrator;
        private ServiceEmployee _employee;
        private ServicePerson _person;
        private ServiceStaff _staff;
        private ServiceStudent _student;
        private ServiceFaculty _faculty;


        public ViewLogin()
        {
            _administrator = new ServiceAdministrator();
            _employee = new ServiceEmployee();
            _faculty = new ServiceFaculty();
            _staff = new ServiceStaff();
            _student = new ServiceStudent();
            _person = new ServicePerson();
        }



        public void LoginMeniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru logare");
            Console.WriteLine("Apasati tasta 2 pentru a va inregista");
            Console.WriteLine("Apasati tasta 3 pentru a reseta parola");
        }

        public void play()
        {
            bool running = true;
            while (running)
            {
                LoginMeniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        NewRegistration();
                        break;

                    case "3":
                        ResetareParola();
                        break;
                }
            }

        }

        public void Login()
        {
            Console.WriteLine("Introde-ti id-ul tau");
            int idLogin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce-ti parola ta");
            string parolaLogin = Console.ReadLine();


            Person person = _person.CheckPersonCredentials(idLogin, parolaLogin);

            if (person != null)
            {
                ViewStudent viewUser = new ViewStudent(person);
                Console.WriteLine("V ati logat cu succes!");
                viewUser.play();
            }
            else
            {
                Console.WriteLine("");
            }

            Administrator admin = _administrator.CheckServiceAdministratorCredentials(idLogin, parolaLogin);

            if (admin != null)
            {
                ViewAdministrator viewAdmin = new ViewAdministrator(admin);
                Console.WriteLine("V ati logat cu succes!");
                viewAdmin.play();
            }

            Staff staff = _staff.CheckServiceStaffCredentials(idLogin, parolaLogin);

            if (staff != null)
            {
                Staff viewStaff = new ViewStaff(staff);
                Console.WriteLine("V ati logat cu succes!");
                viewStaff.play();
            }
            else
            {
                Console.WriteLine("Datele sunt gresite sau nu sunteti inregistrat");
            }
        }

        public void NewRegistration()
        {

            Console.WriteLine("In ce grad aveti dintre:Faculty,  Employee, Administrator, Student, Staff");
            string rankUser = Console.ReadLine();

            switch (rankUser)
            {
                case "Faculty":
                    string typeUser = "Faculty";

                    int idGenerat = _faculty.GenerateId();

                    Console.WriteLine("Care iti este numele de familie?");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Care iti este prenumele?");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Care iti este emailul ?");
                    string userMail = Console.ReadLine();

                    Console.WriteLine("Care iti este parola?");
                    string password = Console.ReadLine();

                    Console.WriteLine("Care iti este numarul de telefon?");
                    int phoneNumber = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate ore de munca lucrai inainte?");
                    int hoursOfService = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cata exerienta de munca aveti?");
                    int lenghOfService = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ce salariu ai avut inainte?");
                    int salary = Int32.Parse(Console.ReadLine());

                    _faculty.AddServiceFaculty(typeUser, idGenerat, firstName, lastName, userMail, password, phoneNumber, hoursOfService, lenghOfService, salary);
                    _faculty.SaveData();
                    Console.WriteLine("Resetarea parolei pentru faculty.");
                    break;

                case "Employee":
                    string typeUserEmployee = "Employee";

                    int idGeneratEmployee = _employee.GenerateId();

                    Console.WriteLine("Care iti este numele de familie?");
                    string firstNameEmployee = Console.ReadLine();

                    Console.WriteLine("Care iti este prenumele?");
                    string lastNameEmployee = Console.ReadLine();

                    Console.WriteLine("Care iti este emailul ?");
                    string userMailEmployee = Console.ReadLine();

                    Console.WriteLine("Care iti este parola?");
                    string passwordEmployee = Console.ReadLine();

                    Console.WriteLine("Care iti este numarul de telefon?");
                    int phoneNumberEmployee = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate ore de munca lucrai inainte?");
                    int hoursOfServiceEmployee = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cata exerienta de munca aveti?");
                    int lenghOfServiceEmployee = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ce salariu ai avut inainte?");
                    int salaryEmployee = Int32.Parse(Console.ReadLine());

                    _employee.AddServiceEmployee(typeUserEmployee, idGeneratEmployee, firstNameEmployee, lastNameEmployee, userMailEmployee, passwordEmployee, phoneNumberEmployee, hoursOfServiceEmployee, lenghOfServiceEmployee, salaryEmployee);
                    _employee.SaveData();
                    Console.WriteLine("Resetarea parolei pentru Employee.");
                    break;

                case "Administrator":

                    string typeUserAdministrator = "Faculty";

                    int idGeneratAdministrator = _faculty.GenerateId();

                    Console.WriteLine("Care iti este numele de familie?");
                    string firstNameAdministrator = Console.ReadLine();

                    Console.WriteLine("Care iti este prenumele?");
                    string lastNameAdministrator = Console.ReadLine();

                    Console.WriteLine("Care iti este emailul ?");
                    string userMailAdministrator = Console.ReadLine();

                    Console.WriteLine("Care iti este parola?");
                    string passwordAdministrator = Console.ReadLine();

                    Console.WriteLine("Care iti este numarul de telefon?");
                    int phoneNumberAdministrator = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate ore de munca lucrai inainte?");
                    int hoursOfServiceAdministrator = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cata exerienta de munca aveti?");
                    int lenghOfServiceAdministrator = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ce salariu ai avut inainte?");
                    int salaryAdministrator = Int32.Parse(Console.ReadLine());

                    _administrator.AddServiceAdministrator(typeUserAdministrator, firstNameAdministrator, firstNameAdministrator, lastNameAdministrator, userMailAdministrator, passwordAdministrator, phoneNumberAdministrator, hoursOfServiceAdministrator, lenghOfServiceAdministrator, salaryAdministrator);
                    _administrator.SaveData();
                    Console.WriteLine("Resetarea parolei pentru administrator.");
                    break;

                case "Student":
                    _student.AddStudent();
                    _student.SaveData();
                    Console.WriteLine("Resetarea parolei pentru student.");
                    break;

                case "Staff":

                    string typeUserStaff = "Faculty";

                    int idGeneratStaff = _faculty.GenerateId();

                    Console.WriteLine("Care iti este numele de familie?");
                    string firstNameStaff = Console.ReadLine();

                    Console.WriteLine("Care iti este prenumele?");
                    string lastNameStaff = Console.ReadLine();

                    Console.WriteLine("Care iti este emailul ?");
                    string userMailStaff = Console.ReadLine();

                    Console.WriteLine("Care iti este parola?");
                    string passwordStaff = Console.ReadLine();

                    Console.WriteLine("Care iti este numarul de telefon?");
                    int phoneNumberStaff = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate ore de munca lucrai inainte?");
                    int hoursOfServiceStaff = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cata exerienta de munca aveti?");
                    int lenghOfServiceStaff = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ce salariu ai avut inainte?");
                    int salaryStaff = Int32.Parse(Console.ReadLine());

                    _staff.AddServiceStaff(typeUserStaff, idGeneratStaff, firstNameStaff, lastNameStaff, userMailStaff, passwordStaff, phoneNumberStaff, hoursOfServiceStaff, lenghOfServiceStaff, salaryStaff);
                    _staff.SaveData();
                    Console.WriteLine("Resetarea parolei pentru staff.");
                    break;

                default:
                    Console.WriteLine("Nu ti-am putut gasii gradul!");
                    break;

            }
        }

        public void ResetareParola()
        {
            Console.WriteLine("Ce grad de user ai? (Faculty, Employee, Administrator, Student, Staff)");
            string userWanted = Console.ReadLine();

            Console.WriteLine("Care este id ul tau?");
            int idWanted = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Care sa fie noua parola");
            string newPassword = Console.ReadLine();

            switch (userWanted)
            {
                case "Faculty":
                    _faculty.EditPasswordById(idWanted, newPassword);
                    _faculty.SaveData();
                    Console.WriteLine("Resetarea parolei pentru faculty.");
                    break;

                case "Employee":
                    _employee.EditPasswordById(idWanted, newPassword);
                    _employee.SaveData();
                    Console.WriteLine("Resetarea parolei pentru Employee.");
                    break;

                case "Administrator":
                    _administrator.EditPasswordById(idWanted, newPassword);
                    _administrator.SaveData();
                    Console.WriteLine("Resetarea parolei pentru administrator.");
                    break;

                case "Student":
                    _student.EditPasswordById(idWanted, newPassword);
                    _student.SaveData();
                    Console.WriteLine("Resetarea parolei pentru student.");
                    break;

                case "Staff":
                    _staff.EditPasswordById(idWanted, newPassword);
                    _staff.SaveData();
                    Console.WriteLine("Resetarea parolei pentru staff.");
                    break;

                default:
                    Console.WriteLine("Nu te-am putut gasi pentru ati reseta parola!");
                    break;
            }
        }
    }
}
