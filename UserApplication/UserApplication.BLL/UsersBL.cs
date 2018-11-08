using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using UserApplication.DAL;

namespace UserApplication.BLL
{
    public class UsersBL
    {
        private readonly IUserDAO usersDAO;

        public UsersBL()
        {
            usersDAO = new UsersDAO();
            //usersDAO = new UsersDAOdb();
        }

        public IEnumerable<User> InitList()
        {
            Add(new User(1, "Иван", "Иванов", "23.04.1996"));
            Add(new User(2, "Иван", "Иванов", "23.04.1996"));
            Add(new User(3, "Иван", "Иванов", "23.04.1996"));
            return GetList();
        }

        public IEnumerable<User> SortStudentsByNameAsc()
        {
            return (from s in GetList()
                    orderby s.FirstName ascending
                    select s);
        }

        public IEnumerable<User> SortStudentsByNameDesc()
        {
            return (from s in GetList()
                    orderby s.FirstName descending
                    select s).ToList();
        }

        public void Add(int id,string firstname, string lastname, string birthday)
        {
            User user = new User(id, firstname, lastname, birthday);
            this.Add(user);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("user");

            usersDAO.Add(user);
        }

        public IEnumerable<User> GetList()
        {
            return usersDAO.GetList();
        }
    }
}
