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

        private ServicePerson _person;

        public ViewLogin()
        {
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
                if (person is Administrator admin)
                {
                    ViewAdministrator viewAdmin = new ViewAdministrator(admin);
                    Console.WriteLine("V-ati logat cu succes!");
                    viewAdmin.play();
                }
                else if (person is Staff staff)
                {
                    ViewStaff viewstaff = new ViewStaff(staff);
                    Console.WriteLine("V-ati logat cu succes!");
                    viewstaff.play();
                }
                else if (person is Faculty faculty)
                {
                    ViewFaculty viewFaculty = new ViewFaculty(faculty);
                    Console.WriteLine("V-ati logat cu succes!");
                    viewFaculty.play();
                }
                //else if (person is Student student)
                //{  
                //    ViewStudent viewStudent = new ViewStudent(student);                                                       //EROARE 1
                //    Console.WriteLine("V-ati logat cu succes!");
                //    viewStudent.play();
                //}
                else
                {
                    Console.WriteLine("Id-ul sau parola sunt gresite!");
                }
                
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

                    int idGenerat = _person.GenerateId();

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

                    Console.WriteLine("Cata exerienta de munca aveti?");
                    int lenghOfService = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate ore de munca lucrai inainte?");
                    int hoursOfService = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ce salariu ai avut inainte?");
                    int salary = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cati studenti ati trecut?");
                    int studentPast = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cati studenti nu ati trecut?");
                    int studentUnPast = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Detineti vreo masina?");
                    int idFacultyvehicle = Int32.Parse(Console.ReadLine());

                    Faculty newFaculty = new Faculty(typeUser, idGenerat, firstName, lastName, userMail, password, phoneNumber, idFacultyvehicle, salary, lenghOfService, hoursOfService, studentPast, studentUnPast);

                    _person.AddPerson(newFaculty);
                    _person.SaveData();
                    Console.WriteLine("Faculty a fost adaugat!");
                    break;

                case "Employee":
                    string typeUserEmployee = "Employee";

                    int idGeneratEmployee = _person.GenerateId();

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

                    Console.WriteLine("Detineti vreo masina?");
                    int vehicleId = Int32.Parse(Console.ReadLine());

                    Employee newEmployee = new Employee(typeUserEmployee, idGeneratEmployee, firstNameEmployee, lastNameEmployee, userMailEmployee, passwordEmployee, phoneNumberEmployee, vehicleId, hoursOfServiceEmployee, lenghOfServiceEmployee, salaryEmployee);

                    _person.AddPerson(newEmployee);
                    _person.SaveData();
                    Console.WriteLine("Employee a fost adaugat.");
                    break;

                case "Administrator":

                    string typeUserAdministrator = "Faculty";

                    int idGeneratAdministrator = _person.GenerateId();

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

                    Console.WriteLine("Cate organizari ai?");
                    int ctOrganizedEvent = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cate probleme ai rezolvate?");
                    int ctProblemSolved = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Detineti vreo masina?");
                    int idAdimistratorVehicle = Int32.Parse(Console.ReadLine());

                    string messagesReceived = " ";

                    Administrator newAdministrator = new Administrator(typeUserAdministrator, idGeneratAdministrator, firstNameAdministrator, lastNameAdministrator, userMailAdministrator, passwordAdministrator, phoneNumberAdministrator, idAdimistratorVehicle, salaryAdministrator, lenghOfServiceAdministrator, hoursOfServiceAdministrator, ctOrganizedEvent, ctProblemSolved, messagesReceived);

                    _person.AddPerson(newAdministrator);
                    _person.SaveData();
                    Console.WriteLine("Administrator a fost adaugat!.");
                    break;

                case "Student":

                    string typeUserStudent = "Student";

                    int idGeneratStudent = _person.GenerateId();

                    Console.WriteLine("Care iti este numele de familie?");
                    string firstNameStudent = Console.ReadLine();

                    Console.WriteLine("Care iti este prenumele?");
                    string lastNameStudent = Console.ReadLine();

                    Console.WriteLine("Care iti este emailul ?");
                    string userMailStudent = Console.ReadLine();

                    Console.WriteLine("Care iti este parola?");
                    string passwordStudent = Console.ReadLine();

                    Console.WriteLine("Care iti este numarul de telefon?");
                    int phoneNumberStudent = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Cati ani ani?");
                    int studentdAge = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("In ce an esti la facultate?");
                    int schoolYear = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Detineti vreo masina?");
                    int idStudentVehicle = Int32.Parse(Console.ReadLine());

                    int remainingExams = 0;

                    Student newStudent = new Student(typeUserStudent, idGeneratStudent, firstNameStudent, lastNameStudent, userMailStudent, passwordStudent, phoneNumberStudent, idStudentVehicle, studentdAge, schoolYear, remainingExams);

                    _person.AddPerson(newStudent);
                    _person.SaveData();
                    Console.WriteLine("Student a fost adaugat!");
                    break;

                case "Staff":

                    string typeUserStaff = "Faculty";

                    int idGeneratStaff = _person.GenerateId();

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

                    Console.WriteLine("De cate ori ati curatat cladirea?");
                    int buildingCleaned = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("De cate ori ati facut inventarul?");
                    int invetoryMade = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Aveti vreo masina?");
                    int vehicleStaffId = Int32.Parse(Console.ReadLine());

                    Staff newStaff = new Staff(typeUserStaff, idGeneratStaff, firstNameStaff, lastNameStaff, userMailStaff, passwordStaff, phoneNumberStaff, vehicleStaffId ,salaryStaff, lenghOfServiceStaff, hoursOfServiceStaff, buildingCleaned, invetoryMade);

                    _person.AddPerson(newStaff);
                    _person.SaveData();
                    Console.WriteLine("Staff a fost adaugat!");
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
                    _person.EditPasswordById(idWanted, newPassword);
                    _person.SaveData();
                    Console.WriteLine("Resetarea parolei pentru faculty.");
                    break;

                case "Administrator":
                    _person.EditPasswordById(idWanted, newPassword);
                    _person.SaveData();
                    Console.WriteLine("Resetarea parolei pentru administrator.");
                    break;

                case "Student":
                    _person.EditPasswordById(idWanted, newPassword);
                    _person.SaveData();
                    Console.WriteLine("Resetarea parolei pentru student.");
                    break;

                case "Staff":
                    _person.EditPasswordById(idWanted, newPassword);
                    _person.SaveData();
                    Console.WriteLine("Resetarea parolei pentru staff.");
                    break;

                default:
                    Console.WriteLine("Nu te-am putut gasi pentru ati reseta parola!");
                    break;
            }
        }
    }
}
