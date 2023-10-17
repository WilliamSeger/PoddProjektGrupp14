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
        private string Length { get; set; }
        public Episode(string name, string description, string length)
        {
            Name = name;
            Description = description;
            Length = length;
        }
    }
}
