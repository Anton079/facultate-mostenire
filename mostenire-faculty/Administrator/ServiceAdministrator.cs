using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServiceAdministrator
    {
        private List<Administrator> _serviceAdministrators;

        public ServiceAdministrator()
        {
            _serviceAdministrators = new List<Administrator>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while (line == sr.ReadLine() != null)
                    {
                        Administrator administrator = new Administrator(line);
                        _serviceAdministrators.Add(administrator);
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

            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                save += _serviceAdministrators[i].ToSave() + "\n";
            }

            save += _serviceAdministrators[_serviceAdministrators.Count - 1].ToSave();

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
        public void AfisareAdministrators()
        {
            foreach (Administrator x in _serviceAdministrators)
            {
                Console.WriteLine(x.AdminInfo());
            }
        }

        public bool AddServiceAdministrator(Administrator newAdmin)
        {
            if (FindServiceAdministratorById(newAdmin.Id) == -1)
            {
                _serviceAdministrators.Add(newAdmin);
                return true;
            }
            return false;
        }

        public int FindServiceAdministratorById(int id)
        {
            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                if (_serviceAdministrators[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindServiceAdministratorNameById(int id)
        {
            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                if (_serviceAdministrators[i].Id == id)
                {
                    return _serviceAdministrators[i].FirstName + " " + _serviceAdministrators[i].LastName;
                }
            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindServiceAdministratorById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                if (_serviceAdministrators[i].Id == id)
                {
                    _serviceAdministrators[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Administratorul nu a fost gasit");
                }
            }
            return false;
        }

        public Administrator CheckServiceAdministratorCredentials(int id, string password)
        {
            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                if (_serviceAdministrators[i].Id == id && _serviceAdministrators[i].Password == password)
                {
                    return _serviceAdministrators[i];
                }
            }
            return null;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _serviceAdministrators.Count; i++)
            {
                if (_serviceAdministrators[i].Id == id)
                {
                    _serviceAdministrators[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }
    }
}
