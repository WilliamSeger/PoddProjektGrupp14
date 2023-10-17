using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Flow
    {
        private string Name { get; set; }
        private Category Category { get; set; }
        private List<Episode> Episodes { get; set; }
        public Flow(string name, Category category, List<Episode> episodes)
        {
            Name = name;
            Category = category;
            Episodes = episodes;
        }


    }
}
