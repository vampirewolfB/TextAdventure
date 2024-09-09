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
        public int Location {  get; set; }

        public Save(int location)
        {
            this.Location = location;
        }
    }
}
