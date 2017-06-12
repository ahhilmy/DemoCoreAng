using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Pies.Any())
            {
                context.Pies.AddRange(new Pie { Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "aaaa", Category = Categories.First().Value },
                    new Pie { Name = "Strawberry Pie2", Price = 16.95M, ShortDescription = "aaaa2", Category = Categories.First().Value },
                    new Pie { Name = "Strawberry Pie3", Price = 17.95M, ShortDescription = "aaaa3", Category = Categories.First().Value },
                    new Pie { Name = "Strawberry Pie4", Price = 18.95M, ShortDescription = "aaaa4", Category = Categories.First().Value },
                    new Pie { Name = "Strawberry Pie5", Price = 19.95M, ShortDescription = "aaaa5", Category = Categories.First().Value });
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var list = new Category[]
                    {
                        new Category{ CategoryName="Fruit pies" },
                        new Category{ CategoryName = "Cheese Cakes" },
                        new Category{ CategoryName="Seasonal pies" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (var item in list)
                    {
                        categories.Add(item.CategoryName, item);
                    }
                }

                return categories;
            }
        }
    }
}
