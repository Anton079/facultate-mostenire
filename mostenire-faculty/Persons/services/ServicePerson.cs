using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServicePerson
    {
        private List<Person> _persList;

        public ServicePerson()
        {
            _persList = new List<Person>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string type = line.Split(',')[0];

                        switch (type)
                        {

                            case "Faculty": _persList.Add(new Faculty(line)); break;

                            case "Student": _persList.Add(new Student(line)); break;

                            case "Staff": _persList.Add(new Staff(line)); break;

                            case "Administrator": _persList.Add(new Administrator(line)); break;

                            default: break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "Person");

            return file;
        }

        public string ToSaveAll()
        {
            string save = "";

            for (int i = 0; i < _persList.Count; i++)
            {
                save += _persList[i].ToSave();

                if( i < _persList.Count - 1)
                {
                    save += "\n";
                }
            }

            return save;
        }


        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    sw.WriteLine(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //CRUD

        

        public void ShowPerson()
        {
            foreach (Person person in _persList)
            {
                Console.WriteLine(person.PersonInfo());
            }
        }

        public void ShowPersonByNameAndLastName(string firstName, string lastName)
        {
            Person person = FindPersonByNameAndLastName(firstName, lastName);
            if (person != null)
            {
                Console.WriteLine($"Student găsit:  Tip de angajat:{person.Type} Id:{person.Id} Email:{person.Email} Nume si prenume:{person.FirstName} {person.LastName}");
            }
            else
            {
                Console.WriteLine("Studentul nu a putut fi găsit.");
            }
        }

        public void ShowSalary()
        {
            foreach (Person person in _persList)
            {
                if (person is Staff)
                {
                    Staff staff = person as Staff;
                    Console.WriteLine(staff.Salary);
                }
                else if (person is Faculty)
                {
                    Faculty faculty = person as Faculty;
                    Console.WriteLine(faculty.Salary);
                }
                else if (person is Administrator)
                {
                    Administrator admin = person as Administrator;
                    Console.WriteLine(admin.Salary);
                }
            }
        }

        public void ShowCuratenie()
        {
            foreach (Person person in _persList)
            {
                if(person is Staff)
                {
                    Staff staff = person as Staff;
                    Console.WriteLine(staff.BuildingCleaned);
                }
            }
        }

        public void ShowPersonByIdVehicle(int idVehicle)
        {
            foreach(Person person in _persList)
            {
                if(person.VehicleId == idVehicle)
                {
                    Console.WriteLine("Persoana pe care o cauti este: " + person.FirstName + " " + person.LastName + " " + person.PhoneNumber + " " + person.Email);
                }
            }
        }

        //REST
        public bool AddPerson(Person newPerson)
        {
            if (newPerson is Student)
            {
                Student student = newPerson as Student;
                _persList.Add(newPerson);
                SaveData();
                return true;
            }
            else if (newPerson is Staff)
            {
                Staff staff = newPerson as Staff;
                _persList.Add(newPerson);
                SaveData();
                return true;
            }
            else if (newPerson is Faculty)
            {
                Faculty faculty = newPerson as Faculty;
                _persList.Add(newPerson);
                SaveData();
                return true;
            }
            else if (newPerson is Administrator)
            {
                Administrator admin = newPerson as Administrator;
                _persList.Add(newPerson);
                SaveData();
                return true;
            }
            return false;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindPersonById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public Person CheckPersonCredentials(int id, string password)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id && _persList[i].Password == password)
                {
                    return _persList[i];
                }
            }
            return null;
        }

        public Person CheckPersonCredentialsJustWithId(int id)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    return _persList[i];
                }
            }
            return null;
        }

        public bool RemovePerson(int idPerson)
        {
            int wantedPerson = FindPersonById(idPerson);
            if (wantedPerson != -1)
            {
                _persList.RemoveAt(wantedPerson);
                SaveData();
                return true;
            }
            return false;
        }

        public bool NewMessageSend(int adminId, string newMessage)
        {
            if (newMessage != null)
            {
                int adminIndex = FindPersonById(adminId);
                if (adminIndex != -1)
                {
                    Administrator admin = _persList[adminIndex] as Administrator;
                    if (admin != null)
                    {
                        admin.MessagesReceived += " " + newMessage;
                        SaveData();
                        return true;
                    }
                }
            }
            return false;
        }


        //FIND
        public int FindPersonById(int id)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public string FindPersonNameById(int id)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    return _persList[i].FirstName + " " + _persList[i].LastName;
                }
            }
            return null;
        }

        public int FindIdByPhoneNumber(int phoneNumber)
        {
            for(int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].PhoneNumber == phoneNumber)
                {
                    return _persList[i].Id;
                }
            }
            return -1;
        }

        public Person FindPersonByNameAndLastName(string firstName, string lastName)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].FirstName == firstName && _persList[i].LastName == lastName)
                {
                    return _persList[i];
                }
            }
            return null;
        }

        public Person FindStaffPersonByNameAndLastName(string firstName, string lastName)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Type == "Staff" && _persList[i].FirstName == firstName && _persList[i].LastName == lastName)
                {
                    return _persList[i];
                }
            }
            return null;
        }


        //EDIT
        public bool EditMailById(int id, string newMail)
        {
            for(int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    _persList[i].Email = newMail;
                    SaveData();
                    return true;
                }
            }
            return false;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    _persList[i].Password = newPassword;
                    SaveData();
                    return true;
                }
            }
            return false;
        }

        public bool EditPhoneNumber(int id, int phoneNuber)
        {
            for(int i = 0; i < _persList.Count; i++)
            {
                if(_persList[i].Id == id)
                {
                    _persList[i].PhoneNumber = phoneNuber;

                    return true;
                }
            }
            return false;
        }

        public bool EditIdVehicle(int idUser, int idVehicle)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == idUser)
                {
                    _persList[i].VehicleId = idVehicle;

                    return true;

                }
            }
            return false;
        }

        public bool EditAllStudentAVehicle(int idVehicle)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i] is Student)
                {
                    _persList[i].VehicleId = idVehicle;

                }
            }
            return false;
        }
    }
}
