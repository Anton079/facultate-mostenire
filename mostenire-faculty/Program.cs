using mostenire_faculty;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //ViewLogin viewLogin = new ViewLogin();

        //ServiceStaff serviceStaff = new ServiceStaff();

        //serviceStaff.AfisareStaff();

        //ServicePerson faculty = new ServicePerson();

        //faculty.AfisarePersons();

        ServicePerson service = new ServicePerson();


        //service.ShowPerson();


        //service.ShowPersonByNameAndLastName("Raul", "Alin");


        //service.ShowSalary();


        //service.ShowCuratenie();


        //Person person = service.CheckPersonCredentials(1, "raul");
        //if (person != null)
        //{
        //    Console.WriteLine($"\nCredentialele verificate pentru ID 1, parola 'password': {person.FirstName} {person.LastName}");
        //}
        //else
        //{
        //    Console.WriteLine("Credentialele sunt greșite");
        //}


        //bool messageSent = service.NewMessageSend(1, "Salut, Alice!");
        //if (messageSent)
        //{
        //    Console.WriteLine("Mesajul a fost trimis!");
        //}
        //else
        //{
        //    Console.WriteLine("Mesajul nu a fost trimis!");
        //}

        /*bool emailEdited = service.EditMailById(1, "newemail@example.com");*/                            //EROARE LA EDITARE EMAIL      2

        bool passwordEdited = service.EditPasswordById(1, "newpassword");
        if (passwordEdited)
        {
            Console.WriteLine("Parola a fost editată cu succes!");
        }
        else
        {
            Console.WriteLine("Parola nu a fost editată!");
        }

        bool phoneNumberEdited = service.EditPhoneNumber(1, 1234567);
        if (phoneNumberEdited)
        {
            Console.WriteLine("Numărul de telefon a fost editat cu succes!");
        }
        else
        {
            Console.WriteLine("Numărul de telefon nu a fost editat!");
        }
    }
}