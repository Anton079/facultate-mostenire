using mostenire_faculty;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        ////ServicePerson faculty = new ServicePerson();

        ////faculty.AfisarePersons();



        //service.ShowPerson();

        ////service.ShowPersonByNameAndLastName("Raul", "Alin");


        ////service.ShowSalary();


        ////service.ShowCuratenie();


        ////Person person = service.CheckPersonCredentials(1, "raul");
        ////if (person != null)
        ////{
        ////    Console.WriteLine($"\nCredentialele verificate pentru ID 1, parola 'password': {person.FirstName} {person.LastName}");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("Credentialele sunt greșite");
        ////}


        ////bool messageSent = service.NewMessageSend(1, "Salut, Alice!");
        ////if (messageSent)
        ////{
        ////    Console.WriteLine("Mesajul a fost trimis!");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("Mesajul nu a fost trimis!");
        ////}

        ////bool emailEdited = service.EditMailById(1, "newemail@example.com");
        ////if(emailEdited )
        ////{
        ////    Console.WriteLine("Email a fost modificat!");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("Email nu a fost modificat!");
        ////}

        ServicePerson service = new ServicePerson();

        service.SaveData();

        //bool passwordEdited = service.EditPasswordById(1, "parolaPusaAcum");
        //if (passwordEdited)
        //{
        //    Console.WriteLine("Parola a fost editată cu succes!");
        //}
        //else
        //{
        //    Console.WriteLine("Parola nu a fost editată!");
        //}



        //service.SaveData();

       // service.LoadData();

        //service.ShowPerson();
        //ServicePerson service = new ServicePerson();

        //bool phoneNumberEdited = service.EditPhoneNumber(1, 1234567);
        //if (phoneNumberEdited)
        //{
        //    Console.WriteLine("Numărul de telefon a fost editat cu succes!");
        //}
        //else
        //{
        //    Console.WriteLine("Numărul de telefon nu a fost editat!");
        //}


        //Student newStudent = new Student("Student", 12, "Raul", "Antonio", "wgtw@gswgegwg.com", "gerge", 05235252, 3, 3, 3);



        //Console.WriteLine(newStudent.ToSave());



        //Administrator newAdministrator = new Administrator("Administrator", 13, "Moghi", "Antonio", "wgtw@gswgegwg.com", "gerge", 05235252, 38888, 3, 3, 1, 4, "da");

        ////Console.WriteLine(newAdministrator.ToSave());

        //Faculty newFaculty = new Faculty("Faculty", 14, "Bogdan", "Antonio", "wgtw@gswgegwg.com", "gerge", 05235252, 3444, 3, 3, 4, 4);

        ////Console.WriteLine(newFaculty.ToSave());

        //Staff newStaff = new Staff("Staff", 15, "Amalia", "Lara", "fwef@gmail.com", "fwefw", 07657474, 3500, 1, 2, 3, 4);

        ////Console.WriteLine(newStaff.ToSave());



        //ServicePerson servicePerson = new ServicePerson();


        //  Console.WriteLine(servicePerson.ToSaveAll());
    }
}