using System;
using mostenire_faculty;
using mostenire_faculty.Vehicles.services;
using mostenire_faculty.Vehicles;
using mostenire_faculty.Vehicles.models;

internal class Program
{
    private static void Main(string[] args)
    {
        ServicePerson servicePerson = new ServicePerson();
        ServiceVehicle serviceVehicle = new ServiceVehicle();

        //servicePerson.ShowPerson();

        Staff newStaff = new Staff("Staff", 4, "Bob", "Brown", "bob.brown@yahoo.com", "password321", 90123, 104, 3000, 5, 40, 3, 5);

        ViewStaff viewStaff = new ViewStaff(newStaff);

        viewStaff.play();

       



        //Student student1 = new Student("Student", 1, "John", "Doe", "john.doe@yahoo.com", "password123",7890,101,3,20,2);
        //Student student2 = new Student("Student", 2, "Jane", "Smith", "jane.smith@yahoo.com", "password456",901,102,2,19,3);
        //Student student3 = new Student("Student", 3, "Alice", "Johnson", "alice.johnson@yahoo.com", "password789",89012,103,1,18,4);

        //Staff staff1 = new Staff("Staff", 4, "Bob", "Brown", "bob.brown@yahoo.com", "password321", 90123, 104, 3000, 5, 40, 3, 5);
        //Staff staff2 = new Staff("Staff", 5, "Charlie", "Davis", "charlie.davis@yahoo.com", "password654",1234,105,3200,6,40,4,6);
        //Staff staff3 = new Staff("Staff", 6, "Dave", "Wilson", "dave.wilson@yahoo.com", "password987",12345, 106, 3100, 7, 40, 2, 4);

        //Faculty faculty1 = new Faculty("Faculty", 7, "Eve", "Miller", "eve.miller@yahoo.com", "password741",3456, 107, 3500, 8, 40, 50, 5);
        //Faculty faculty2 = new Faculty("Faculty", 8, "Frank", "Moore", "frank.moore@yahoo.com", "password852",34567, 108, 3600, 9, 40, 60, 3);
        //Faculty faculty3 = new Faculty("Faculty", 9, "Grace", "Taylor", "grace.taylor@yahoo.com", "password963",5678, 109, 3400, 10, 40, 55, 4);

        //Administrator admin1 = new Administrator("Administrator", 10, "Hank", "Anderson", "hank.anderson@yahoo.com", "password159", 4560, 110, 4000, 10, 50, 10, 20, "Welcome to the team!");
        //Administrator admin2 = new Administrator("Administrator", 11, "Ivy", "Scott", "ivy.scott@yahoo.com", "password753", 7651, 111, 4100, 11, 50, 12, 22, "Meeting at 10 AM.");
        //Administrator admin3 = new Administrator("Administrator", 12, "Jack", "Williams", "jack.williams@yahoo.com", "password456", 98762, 112, 4200, 12, 50, 15, 25, "Please check your email.");

        //List<Person> _persList = new List<Person>();
        //_persList.Add(admin1);
        //_persList.Add(admin2);
        //_persList.Add(admin3);

        //_persList.Add(student1);
        //_persList.Add(student2);
        //_persList.Add(student3);

        //_persList.Add(staff1);
        //_persList.Add(staff2);
        //_persList.Add(staff3);

        //_persList.Add(faculty1);
        //_persList.Add(faculty2);
        //_persList.Add(faculty3);

        //foreach(Person person in _persList)
        //{
        //    Console.WriteLine(person.PersonInfo());
        //}





        //Coupe coupe1 = new Coupe("BMW", 1, 300, 500, 10000, "Leather", 6, 350, "Da", "Sportiv", "Redus");
        //Coupe coupe2 = new Coupe("Audi", 2, 320, 520, 12000, "Plastic", 4, 330, "Da", "Elegant", "Mediu");
        //Coupe coupe3 = new Coupe("Mercedes", 3, 310, 510, 11000, "Leather", 8, 340, "Nu", "Agresiv", "Minim");

        //Motorcycle moto1 = new Motorcycle("Yamaha", 4, 200, 300, 8000, "Sport", "Standard", "Manual");
        //Motorcycle moto2 = new Motorcycle("Suzuki", 5, 220, 320, 8500, "Cruiser", "Optional", "Hidraulic");
        //Motorcycle moto3 = new Motorcycle("Kawasaki", 6, 210, 310, 8300, "Naked", "Absent", "Manual");

        //Sedan sedan1 = new Sedan("Toyota", 7, 180, 250, 9000, "Multifunctional", 6, 500, "Mediu", "Confortabil", "Generos");
        //Sedan sedan2 = new Sedan("Honda", 8, 170, 240, 9200, "Standard", 4, 480, "Mediu", "Economic", "Compact");
        //Sedan sedan3 = new Sedan("Hyundai", 9, 175, 245, 9100, "Sport", 8, 490, "Mediu", "Luxos", "Optimizat");

        //Suv suv1 = new Suv("Jeep", 10, 250, 400, 12000, "Electric", 10, 700, "Mare", "Inalt", "4x4");
        //Suv suv2 = new Suv("Ford", 11, 260, 410, 12500, "Multifunctional", 8, 680, "Mare", "Inalt", "Off-road");
        //Suv suv3 = new Suv("Chevrolet", 12, 270, 420, 12300, "Standard", 6, 690, "Mare", "Inalt", "Suportat");

        //List<Vehicle> _vehicleList = new List<Vehicle>();
        //_vehicleList.Add(sedan1);
        //_vehicleList.Add(sedan2);
        //_vehicleList.Add(sedan3);

        //_vehicleList.Add(suv1);
        //_vehicleList.Add(suv2);
        //_vehicleList.Add(suv3);

        //_vehicleList.Add(moto1);
        //_vehicleList.Add(moto2);
        //_vehicleList.Add(moto3);

        //_vehicleList.Add(coupe1);
        //_vehicleList.Add(coupe2);
        //_vehicleList.Add(coupe3);

        //foreach(Vehicle v in _vehicleList)
        //{
        //    Console.WriteLine(v.VehicleInfo());
        //}


















        ////ADMINISTRATOR

        ////1
        //Console.WriteLine("Testare optiunea 1: Afisare tuturor persoanelor din facultate!");
        //servicePerson.ShowPerson();

        ////2
        //Console.WriteLine("\nTestare optiunea 2: Cautare student dupa nume si prenume");
        //string testFirstName = "Mary";
        //string testLastName = "Anne";
        //Person foundPerson = servicePerson.FindPersonByNameAndLastName(testFirstName, testLastName);
        //if (foundPerson != null)
        //{
        //    Console.WriteLine($"{foundPerson.Type} cu numele {testFirstName} {testLastName} a fost gasit.");
        //}
        //else
        //{
        //    Console.WriteLine($"Studentul {testFirstName} {testLastName} nu a fost gasit.");
        //}

        ////3
        //Console.WriteLine("\nTestare optiunea 3: Afisare tot staff-ul");
        //servicePerson.ShowPersonByType("Staff");

        ////4
        //Console.WriteLine("\nTestare optiunea 4: Cautare staff dupa nume si prenume");
        //servicePerson.ShowPersonByNameAndLastName("Ionut", "Bogdan");


        ////5
        //Console.WriteLine("\nTestare optiunea 5: Afisare tot faculty-ul");
        //servicePerson.ShowPersonByType("Faculty");

        ////6
        //Console.WriteLine("\nTestare optiunea 6: Cautare faculty dupa nume si prenume");
        //testFirstName = "Rares";
        //testLastName = "Bogdan";
        //foundPerson = servicePerson.FindPersonByNameAndLastName(testFirstName, testLastName);
        //if (foundPerson != null)
        //{
        //    Console.WriteLine($"Faculty-ul {testFirstName} {testLastName} a fost gasit.");
        //}
        //else
        //{
        //    Console.WriteLine($"Faculty-ul {testFirstName} {testLastName} nu a fost gasit.");
        //}

        ////7
        //Console.WriteLine("\nTestare optiunea 7: Stergere student din facultate");
        //int testStudentId = 1;
        //bool removed = servicePerson.RemovePerson(testStudentId);
        //if (removed)
        //{
        //    Console.WriteLine($"Studentul cu ID-ul {testStudentId} a fost sters.");
        //}
        //else
        //{
        //    Console.WriteLine($"Studentul cu ID-ul {testStudentId} nu a putut fi sters sau nu a fost gasit.");
        //}

        ////8
        //Console.WriteLine("\nTestare optiunea 8: Stergere staff din facultate");
        //int testStaffId = 10;
        //removed = servicePerson.RemovePerson(testStaffId);
        //if (removed)
        //{
        //    Console.WriteLine($"Staff-ul cu ID-ul {testStaffId} a fost sters.");
        //}
        //else
        //{
        //    Console.WriteLine($"Staff-ul cu ID-ul {testStaffId} nu a putut fi sters sau nu a fost gasit.");
        //}

        ////9
        //Console.WriteLine("\nTestare optiunea 9: Stergere faculty din facultate");
        //int testFacultyId = 12;
        //removed = servicePerson.RemovePerson(testFacultyId);
        //if (removed)
        //{
        //    Console.WriteLine($"Faculty-ul cu ID-ul {testFacultyId} a fost sters.");
        //}
        //else
        //{
        //    Console.WriteLine($"Faculty-ul cu ID-ul {testFacultyId} nu a putut fi sters sau nu a fost gasit.");
        //}

        ////Faculty

        ////3
        //Console.WriteLine("Testarea functie 3");
        //if(servicePerson.EditMailById(3, "horia_dragu@yaho0.com"))
        //{
        //    Console.WriteLine("Mail a fost edita");
        //}
        //else
        //{
        //    Console.WriteLine("Mailul nu a fost editat");
        //}

        ////4
        //Console.WriteLine("Testarea functie 4");
        //if(servicePerson.EditPasswordById(3, "parolaNouaAIci"))
        //{
        //    Console.WriteLine("Parola a fost editata");
        //}
        //else
        //{
        //    Console.WriteLine("Parola nu a fost editata");
        //}

        ////5
        //Console.WriteLine("Testarea functie 5");
        //if(servicePerson.EditPhoneNumber(3, 051515115))
        //{
        //    Console.WriteLine("Numarul a fost editat");
        //}
        //else
        //{
        //    Console.WriteLine("Numarul nu a fost editat");
        //}

        ////7
        //Console.WriteLine("Testarea functie 7");
        //if(servicePerson.NewMessageSend(1, "Mesaj nou!"))
        //{
        //    Console.WriteLine("Mesajul a fost trimis!");
        //}
        //else
        //{
        //    Console.WriteLine("Mesajul nu a fost trimis");
        //}

        ////VIEW

        ////1. SHOW VEHICLE
        //serviceVehicle.ShowVehicles();

        ////2.
        //servicePerson.ShowPersonByIdVehicle(2);

        ////3.
        //serviceVehicle.ShowMostUsedVehicle();

        ////4.
        //if (serviceVehicle.RemoveAVehicle(3))
        //{
        //    Console.WriteLine("Functia remove a mers la masina");
        //}
        //else
        //{
        //    Console.WriteLine("Functia remove nu a reusit");
        //}

        ////5.
        //if (servicePerson.EditIdVehicle(1, 2))
        //{
        //    Console.WriteLine("Masina a putut fi modificata");
        //}
        //else
        //{
        //    Console.WriteLine("Masina nu a putut fi modificata");
        //}
        //servicePerson.SaveData();

        ////6.
        //if (servicePerson.EditAllStudentAVehicle(3))
        //{
        //    Console.WriteLine("Editul a fost reusit!");
        //}
        //else
        //{
        //    Console.WriteLine("Editul nu a reusit!");
        //}

        ////7.
        //if (3 is Vehicle)
        //{
        //    servicePerson.EditIdVehicle(1, 3);
        //    servicePerson.SaveData();
        //}
        //else
        //{
        //    Console.WriteLine("Masina nu a fost gasita!");
        //}


    }
}