using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UserApplication.DAL
{
    public interface IUserDAO
    {
        void Add(User user);
        System.Collections.Generic.IEnumerable<User> GetList();
    }
}
