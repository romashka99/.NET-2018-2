using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using UserApplication.DAL;

namespace UserApplication.BLL
{
    class RewardsBL
    {
        private readonly IRewardDAO rewardsDAO;

        public RewardsBL()
        {
            rewardsDAO = new RewardDAO();
            //rewardsDAO = new UsersDAOdb();
        }

        public IEnumerable<Reward> InitList()
        {
            Add(new Reward(1, "Нобелевская премия"));
            Add(new Reward(2, "Премия Дарвина"));
            Add(new Reward(3, "Премия Абеля"));
            return GetList();
        }

        public IEnumerable<Reward> SortStudentsByNameAsc()
        {
            return (from s in GetList()
                    orderby s.Title ascending
                    select s);
        }

        public IEnumerable<Reward> SortStudentsByNameDesc()
        {
            return (from s in GetList()
                    orderby s.Title descending
                    select s).ToList();
        }

        public void Add(int id, string title, string description)
        {
            Reward reward = new Reward(id, title, description);
            this.Add(reward);
        }

        public void Add(Reward reward)
        {
            if (reward == null)
                throw new ArgumentException("reward");

            rewardsDAO.Add(reward);
        }

        public IEnumerable<Reward> GetList()
        {
            return rewardsDAO.GetList();
        }
    }
}
