using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Models
{
    public class Pie
    {
        public int PieId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public bool IsPieOfTheWeek { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
