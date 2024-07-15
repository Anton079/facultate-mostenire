using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServiceFaculty
    {
        private List<Faculty> _serviceFaculty;

        public ServiceFaculty()
        {
            _serviceFaculty = new List<Faculty>();
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
                        Faculty faculty = new Faculty(line);
                        _serviceFaculty.Add(faculty);
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

            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                save += _serviceFaculty[i].ToSave() + "\n";
            }

            save += _serviceFaculty[_serviceFaculty.Count - 1].ToSave();

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

        public void AfisareFaculty()
        {
            foreach (Faculty x in _serviceFaculty)
            {
                Console.WriteLine(x.FacultyInfo());
            }
        }

        public bool AddServiceFaculty(Faculty newFaculty)
        {
            if (FindServiceFacultyById(newFaculty.Id) == -1)
            {
                _serviceFaculty.Add(newFaculty);
                return true;
            }
            return false;
        }

        public int FindServiceFacultyById(int id)
        {
            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                if (_serviceFaculty[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindServiceFacultyNameById(int id)
        {
            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                if (_serviceFaculty[i].Id == id)
                {
                    return _serviceFaculty[i].FirstName + " " + _serviceFaculty[i].LastName;
                }
            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindServiceFacultyById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                if (_serviceFaculty[i].Id == id)
                {
                    _serviceFaculty[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Facultatea de serviciu nu a fost gasita");
                }
            }
            return false;
        }

        public Faculty CheckServiceFacultyCredentials(int id, string password)
        {
            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                if (_serviceFaculty[i].Id == id && _serviceFaculty[i].Password == password)
                {
                    return _serviceFaculty[i];
                }
            }
            return null;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _serviceFaculty.Count; i++)
            {
                if (_serviceFaculty[i].Id == id)
                {
                    _serviceFaculty[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }
    }
}
