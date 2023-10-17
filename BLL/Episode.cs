using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Episode
    {
        private string Name {  get; set; }
        private string Description { get; set; }
        public Episode(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
