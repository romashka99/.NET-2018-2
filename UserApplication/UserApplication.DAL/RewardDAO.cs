using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace UserApplication.DAL
{
    public class RewardDAO : IRewardDAO
    {
        private List<Reward> rewards = new List<Reward>();
        public void Add(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("reward");
            rewards.Add(reward);
        }

        public IEnumerable<Reward> GetList()
        {
            return rewards;
        }
    }

    public class RewardDAOdb : IRewardDAO
    {
        public void Add(Reward reward)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reward> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
