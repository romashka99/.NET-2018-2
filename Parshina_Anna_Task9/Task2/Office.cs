using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
namespace Task2
{
    class Office
    {
        List<Person> listEmployee = new List<Person>();
        public void CameEmployee(string name, DateTime datacame)
        {
            Person Employee = new Person(name);
            Employee.TimeCame = datacame;
            foreach (Person item in listEmployee)
            {
                Employee.Came += item.Greet;
            }
            Employee.OnCame();
            listEmployee.Add(Employee);
        }

        private Person FindEmployee(string name)
        {
            foreach (Person item in listEmployee)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }

        public void BackEmployee(string name)
        {
            Person Employee = FindEmployee(name);
            listEmployee.Remove(Employee);
            foreach (Person item in listEmployee)
            {
                Employee.Came -= item.Greet;
                Employee.BackHome += item.Bye;
            }
            Employee.Remove();
        }
    }
}
