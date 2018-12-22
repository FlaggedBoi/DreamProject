using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamProject
{
  class Character
    {
        string name;
        private int hp;
        int XP;
        protected int[,] placement { get; private set; }
        List<String> inventory;
        public Character(string name)
        {
            this.name = name;
        }       
    }
}
