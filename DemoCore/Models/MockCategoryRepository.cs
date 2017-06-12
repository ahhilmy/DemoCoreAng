using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Fruit Pies" },
                    new Category{CategoryId=2, CategoryName="Cheese Cake" },
                    new Category{CategoryId=3, CategoryName="Seasonal Pies" }
                };
            }
        }
    }
}
