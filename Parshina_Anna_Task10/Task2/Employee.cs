using System;

namespace Task2
{
    class Employee : User, IEquatable<Employee>
    {
        static private int id;
        static private int ID()
        {
            return id++;
        }

        private int idnamber;
        private int IDNamber
        {
            get
            {
                return idnamber;
            }
            set
            {
                idnamber = id;
            }
        }
        

        public Employee(string surname, string name, DateTime dateborn, string position, DateTime employeymentdate) : base(surname, name, dateborn)
        {
            EmployeymentDate = employeymentdate;
            Position = position;
        }
        private DateTime employeymentdate;
        public DateTime EmployeymentDate
        {
            get
            {
                return employeymentdate;
            }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Дата не может быть больше нынешней даты");
                }
                else employeymentdate = value;
            }
        }
        private int WorkExperience
        {
            get
            {
                int age;
                DateTime date = DateTime.Today;
                if (date.Month < EmployeymentDate.Month && date.Day < EmployeymentDate.Day)
                    age = date.Year - EmployeymentDate.Year;
                else age = date.Year - EmployeymentDate.Year - 1;
                return age;
            }
        }
        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Employee должен иметь должность");
                }
                else position = value;
            }
        }

        public void GetInformation()
        {
            Console.WriteLine("ID: " + IDNamber);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Стаж работы: " + WorkExperience);
        }

        public bool Equals(Employee other)
        {
            if (other == null) return false;
            if (this.IDNamber == other.IDNamber) return true;
            else return false;
        }

        public override bool Equals(Object obj)
        {
            Employee personObj = obj as Employee;
            if (personObj == null)
                return false;
            else
                return idnamber.Equals(personObj.idnamber);
        }

        public override int GetHashCode()
        {
            return this.idnamber.GetHashCode();
        }
    }
}
