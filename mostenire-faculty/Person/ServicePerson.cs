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
                        string type = line.Split(' ')[0];

                        switch (type)
                        {

                            case "Student": _persList.Add(new Student(line)); break;

                            case "Faculty": _persList.Add(new Faculty(line)); break;

                            case "Staff": _persList.Add(new Staff(line)); break;

                            case "Administrator": _persList.Add(new Administrator(line)); break;
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
                save += _persList[i].ToSave() + "\n";
            }

            save += _persList[_persList.Count - 1].ToSave();

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

        public void AfisarePersons()
        {
            foreach (Person person in _persList)
            {
                Console.WriteLine(person.PersonInfo());
            }
        }

        public bool AddPerson(Person newPerson)
        {
            if (FindPersonById(newPerson.Id) == -1)
            {
                _persList.Add(newPerson);
                return true;
            }
            return false;
        }

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

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    _persList[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Persoana nu a fost gasita");
                }
            }
            return false;
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

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _persList.Count; i++)
            {
                if (_persList[i].Id == id)
                {
                    _persList[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }
    }
}
