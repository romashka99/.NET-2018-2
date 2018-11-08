using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reward
    {
        private int id;

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("У награды должно быть название");
                }
                if (value.Length > 50)
                {
                    throw new Exception("Название не должно превышать 50 символов");
                }
                title = value;
            }
        }
        public string Description
        {
            set
            {
                if (value.Length > 250)
                {
                    throw new Exception("Описание не должно превышать 250 символов");
                }
            }
        }

        public Reward(int id, string title, string description = "/0")
        {
            this.id = id;
            Title = title;
            Description = description;
        }
    }
}
