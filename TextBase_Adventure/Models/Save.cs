using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBase_Adventure.Models
{
    internal class Save
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public string Location {  get; set; }
        public int Points {  get; set; } 
        public int Coins { get; set; }

        public Save(string name, int health, string location, int points, int coins)
        {
            this.Name = name;
            this.Health = health;
            this.Location = location;
            this.Points = points;
            this.Coins = coins;
        }
        public Save() { } 
    }
}
