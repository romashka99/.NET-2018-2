using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UserApplication.DAL
{
    public interface IRewardDAO
    {
        void Add(Reward reward);
        System.Collections.Generic.IEnumerable<Reward> GetList();
    }
}
