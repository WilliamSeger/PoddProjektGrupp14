using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Flow
    {
        private string Name { get; set; }
        private string Title { get; set; }
        private Category Category { get; set; }
        private List<Episode> Episodes { get; set; }
        public Flow(string name, string title, Category category, List<Episode> episodes)
        {
            Name = name;
            Title = title;
            Category = category;
            Episodes = episodes;
        }


    }
}
