using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UserApplication.DAL
{
    public class UsersDAO : IUserDAO
    {
        private List<User> users = new List<User>();
        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("user");
            users.Add(user);
        }

        public IEnumerable<User> GetList()
        {
            return users;
        }
    }

    public class UsersDAOdb : IUserDAO
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
