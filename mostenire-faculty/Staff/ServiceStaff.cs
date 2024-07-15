using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServiceStaff
    {
        private List<Staff> _serviceStaff;

        public ServiceStaff()
        {
            _serviceStaff = new List<Staff>();
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
                        Staff staff = new Staff(line);
                        _serviceStaff.Add(staff);
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

            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                save += _serviceStaff[i].ToSave() + "\n";
            }

            save += _serviceStaff[_serviceStaff.Count - 1].ToSave();

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

        public void AfisareStaff()
        {
            foreach (Staff x in _serviceStaff)
            {
                Console.WriteLine(x.SaffInfo());
            }
        }

        public bool AddServiceStaff(Staff newStaff)
        {
            if (FindServiceStaffById(newStaff.Id) == -1)
            {
                _serviceStaff.Add(newStaff);
                return true;
            }
            return false;
        }

        public int FindServiceStaffById(int id)
        {
            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                if (_serviceStaff[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindServiceStaffNameById(int id)
        {
            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                if (_serviceStaff[i].Id == id)
                {
                    return _serviceStaff[i].FirstName + " " + _serviceStaff[i].LastName;
                }
            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindServiceStaffById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                if (_serviceStaff[i].Id == id)
                {
                    _serviceStaff[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Personalul de serviciu nu a fost gasit");
                }
            }
            return false;
        }

        public Staff CheckServiceStaffCredentials(int id, string password)
        {
            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                if (_serviceStaff[i].Id == id && _serviceStaff[i].Password == password)
                {
                    return _serviceStaff[i];
                }
            }
            return null;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _serviceStaff.Count; i++)
            {
                if (_serviceStaff[i].Id == id)
                {
                    _serviceStaff[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }
    }
}
