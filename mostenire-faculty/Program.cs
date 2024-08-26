using System;
using mostenire_faculty;
using mostenire_faculty.Vehicles.services;

internal class Program
{
    private static void Main(string[] args)
    {
        ServicePerson servicePerson = new ServicePerson();
        ServiceVehicle serviceVehicle = new ServiceVehicle();



        //ADMINISTRATOR

        //1
        Console.WriteLine("Testare optiunea 1: Afisare tuturor persoanelor din facultate!");
        servicePerson.ShowPerson();

        //2
        Console.WriteLine("\nTestare optiunea 2: Cautare student dupa nume si prenume");
        string testFirstName = "Mary";
        string testLastName = "Anne";
        Person foundPerson = servicePerson.FindPersonByNameAndLastName(testFirstName, testLastName);
        if (foundPerson != null)
        {
            Console.WriteLine($"{foundPerson.Type} cu numele {testFirstName} {testLastName} a fost gasit.");
        }
        else
        {
            Console.WriteLine($"Studentul {testFirstName} {testLastName} nu a fost gasit.");
        }

        //3
        Console.WriteLine("\nTestare optiunea 3: Afisare tot staff-ul");
        servicePerson.ShowPersonByType("Staff");

        //4
        Console.WriteLine("\nTestare optiunea 4: Cautare staff dupa nume si prenume");
        servicePerson.ShowPersonByNameAndLastName("Ionut", "Bogdan");


        //5
        Console.WriteLine("\nTestare optiunea 5: Afisare tot faculty-ul");
        servicePerson.ShowPersonByType("Faculty");

        //6
        Console.WriteLine("\nTestare optiunea 6: Cautare faculty dupa nume si prenume");
        testFirstName = "Rares";
        testLastName = "Bogdan";
        foundPerson = servicePerson.FindPersonByNameAndLastName(testFirstName, testLastName);
        if (foundPerson != null)
        {
            Console.WriteLine($"Faculty-ul {testFirstName} {testLastName} a fost gasit.");
        }
        else
        {
            Console.WriteLine($"Faculty-ul {testFirstName} {testLastName} nu a fost gasit.");
        }

        //7
        Console.WriteLine("\nTestare optiunea 7: Stergere student din facultate");
        int testStudentId = 1;
        bool removed = servicePerson.RemovePerson(testStudentId);
        if (removed)
        {
            Console.WriteLine($"Studentul cu ID-ul {testStudentId} a fost sters.");
        }
        else
        {
            Console.WriteLine($"Studentul cu ID-ul {testStudentId} nu a putut fi sters sau nu a fost gasit.");
        }

        //8
        Console.WriteLine("\nTestare optiunea 8: Stergere staff din facultate");
        int testStaffId = 10;
        removed = servicePerson.RemovePerson(testStaffId);
        if (removed)
        {
            Console.WriteLine($"Staff-ul cu ID-ul {testStaffId} a fost sters.");
        }
        else
        {
            Console.WriteLine($"Staff-ul cu ID-ul {testStaffId} nu a putut fi sters sau nu a fost gasit.");
        }

        //9
        Console.WriteLine("\nTestare optiunea 9: Stergere faculty din facultate");
        int testFacultyId = 12;
        removed = servicePerson.RemovePerson(testFacultyId);
        if (removed)
        {
            Console.WriteLine($"Faculty-ul cu ID-ul {testFacultyId} a fost sters.");
        }
        else
        {
            Console.WriteLine($"Faculty-ul cu ID-ul {testFacultyId} nu a putut fi sters sau nu a fost gasit.");
        }

        //Faculty

        //3
        Console.WriteLine("Testarea functie 3");
        if(servicePerson.EditMailById(3, "horia_dragu@yaho0.com"))
        {
            Console.WriteLine("Mail a fost edita");
        }
        else
        {
            Console.WriteLine("Mailul nu a fost editat");
        }

        //4
        Console.WriteLine("Testarea functie 4");
        if(servicePerson.EditPasswordById(3, "parolaNouaAIci"))
        {
            Console.WriteLine("Parola a fost editata");
        }
        else
        {
            Console.WriteLine("Parola nu a fost editata");
        }

        //5
        Console.WriteLine("Testarea functie 5");
        if(servicePerson.EditPhoneNumber(3, 051515115))
        {
            Console.WriteLine("Numarul a fost editat");
        }
        else
        {
            Console.WriteLine("Numarul nu a fost editat");
        }

        //7
        Console.WriteLine("Testarea functie 7");
        if(servicePerson.NewMessageSend(1, "Mesaj nou!"))
        {
            Console.WriteLine("Mesajul a fost trimis!");
        }
        else
        {
            Console.WriteLine("Mesajul nu a fost trimis");
        }

        //VIEW

        //1. SHOW VEHICLE
        serviceVehicle.ShowVehicles();

        //2.
        servicePerson.ShowPersonByIdVehicle(2);

        //3.
        serviceVehicle.ShowMostUsedVehicle();

        //4.
        if (serviceVehicle.RemoveAVehicle(3))
        {
            Console.WriteLine("Functia remove a mers la masina");
        }
        else
        {
            Console.WriteLine("Functia remove nu a reusit");
        }

        //5.
        if (servicePerson.EditIdVehicle(1, 2))
        {
            Console.WriteLine("Masina a putut fi modificata");
        }
        else
        {
            Console.WriteLine("Masina nu a putut fi modificata");
        }
        servicePerson.SaveData();

        //6.
        if (servicePerson.EditAllStudentAVehicle(3))
        {
            Console.WriteLine("Editul a fost reusit!");
        }
        else
        {
            Console.WriteLine("Editul nu a reusit!");
        }

        //7.
        if (3 is Vehicle)
        {
            servicePerson.EditIdVehicle(1, 3);
            servicePerson.SaveData();
        }
        else
        {
            Console.WriteLine("Masina nu a fost gasita!");
        }
    }
}
