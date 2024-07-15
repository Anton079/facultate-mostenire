using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServiceEmployee
    {
        private List<Employee> _serviceEmployees;

        public ServiceEmployee()
        {
            _serviceEmployees = new List<Employee>();
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
                        Employee employee = new Employee(line);
                        _serviceEmployees.Add(employee);
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

            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                save += _serviceEmployees[i].ToSave() + "\n";
            }

            save += _serviceEmployees[_serviceEmployees.Count - 1].ToSave();

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

        public void AfisareEmployee()
        {
            foreach (Employee x in _serviceEmployees)
            {
                Console.WriteLine(x.EmployeeInfo());
            }
        }

        public bool AddServiceEmployee(Employee newEmployee)
        {
            if (FindServiceEmployeeById(newEmployee.Id) == -1)
            {
                _serviceEmployees.Add(newEmployee);
                return true;
            }
            return false;
        }

        public int FindServiceEmployeeById(int id)
        {
            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                if (_serviceEmployees[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindServiceEmployeeNameById(int id)
        {
            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                if (_serviceEmployees[i].Id == id)
                {
                    return _serviceEmployees[i].FirstName + " " + _serviceEmployees[i].LastName;
                }
            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindServiceEmployeeById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                if (_serviceEmployees[i].Id == id)
                {
                    _serviceEmployees[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Angajatul de serviciu nu a fost gasit");
                }
            }
            return false;
        }

        public Employee CheckServiceEmployeeCredentials(int id, string password)
        {
            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                if (_serviceEmployees[i].Id == id && _serviceEmployees[i].Password == password)
                {
                    return _serviceEmployees[i];
                }
            }
            return null;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _serviceEmployees.Count; i++)
            {
                if (_serviceEmployees[i].Id == id)
                {
                    _serviceEmployees[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }
    }
}
