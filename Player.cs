using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamProject
{
  class Player
    {
        string name;
        int hp;
        int XP;
        protected int[,] placement { get; private set; }
        List<String> inventory;
        public Player(string name)
        {
            this.name = name;
        }       
    }
}
