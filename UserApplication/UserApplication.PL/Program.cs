using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApplication.BLL;


namespace UserApplication.PL
{
    class Program
    {

        static void Main(string[] args)
        {
            UsersBL users = new UsersBL();
            users.InitList();
            users.Add(5, "Николай", "Николаев", "12.04.2001");
        }
    }
}
