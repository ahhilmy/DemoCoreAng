using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> Pies {
            get
            {
                return new List<Pie> {
                    new Pie{ PieId=1, Name="Strawberry Pie", Price=15.95M, ShortDescription="aaaa" },
                    new Pie{ PieId=2, Name="Strawberry Pie2", Price=16.95M, ShortDescription="aaaa2" },
                    new Pie{ PieId=3, Name="Strawberry Pie3", Price=17.95M, ShortDescription="aaaa3" },
                    new Pie{ PieId=4, Name="Strawberry Pie4", Price=18.95M, ShortDescription="aaaa4" },
                    new Pie{ PieId=5, Name="Strawberry Pie5", Price=19.95M, ShortDescription="aaaa5" }
                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek {
            get
            {
                return null;
            }
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
