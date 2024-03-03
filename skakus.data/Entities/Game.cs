using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Game(string name)
        {
            Name = name;
        }
    }
}
