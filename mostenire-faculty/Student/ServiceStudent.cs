using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace mostenire_faculty
{
    public class ServiceStudent
    {
        private List<Student> _serviceStudent;

        public ServiceStudent()
        {
            _serviceStudent = new List<Student>();
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
                        Student student = new Student(line);
                        _serviceStudent.Add(student);
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

            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                save += _serviceStudent[i].ToSave() + "\n";
            }

            save += _serviceStudent[_serviceStudent.Count - 1].ToSave();

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

        public void AfisareStudents()
        {
            foreach (Student student in _serviceStudent)
            {
                Console.WriteLine(student.PersonInfo());
            }
        }

        public bool AddStudent(Student newStudent)
        {
            if (FindStudentById(newStudent.Id) == -1)
            {
                _serviceStudent.Add(newStudent);
                return true;
            }
            return false;
        }

        public int FindStudentById(int id)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindStudentNameById(int id)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].Id == id)
                {
                    return _serviceStudent[i].FirstName + " " + _serviceStudent[i].LastName;
                }
            }
            return null;
        }

        public int GenerateId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 10000000);

            while (FindStudentById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }

            return id;
        }

        public bool EditPhoneNumberById(int id, int newPhoneNumber)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].Id == id)
                {
                    _serviceStudent[i].PhoneNumber = newPhoneNumber;
                    return true;
                }
                else
                {
                    Console.WriteLine("Studentul nu a fost gasit");
                }
            }
            return false;
        }

        public Student CheckStudentCredentials(int id, string password)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].Id == id && _serviceStudent[i].Password == password)
                {
                    return _serviceStudent[i];
                }
            }
            return null;
        }

        public bool EditPasswordById(int id, string newPassword)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].Id == id)
                {
                    _serviceStudent[i].Password = newPassword;
                    return true;
                }
            }
            return false;
        }

        public Student FindStudentByFirstAndLastName(string firstName, string lastName)
        {
            for (int i = 0; i < _serviceStudent.Count; i++)
            {
                if (_serviceStudent[i].FirstName == firstName && _serviceStudent[i].LastName == lastName)
                {
                    return _serviceStudent[i];
                }
            }
            return null;
        }

        public void AfisareStudentByNameAndLastName(string firstName, string lastName)
        {
            Student student = FindStudentByFirstAndLastName(firstName, lastName);
            if (student != null)
            {
                Console.WriteLine($"Student găsit: {student.FirstName} {student.LastName}");
            }
            else
            {
                Console.WriteLine("Studentul nu a putut fi găsit.");
            }
        }
    }
}
