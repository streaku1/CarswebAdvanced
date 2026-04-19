using Carsweb.Models;

namespace Carsweb.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Cars { Name = "S63", Brand = "Mercedes", Price = 185000 },
                    new Cars { Name = "RS6", Brand = "Audi", Price = 160000 },
                    new Cars { Name = "M5", Brand = "BMW", Price = 145000 }
                );
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { Name = "John Doe", Email = "john@test.com", Phone = "123", Address = "Street 1" },
                    new Customer { Name = "Anna Smith", Email = "anna@test.com", Phone = "456", Address = "Street 2" }
                );
            }

            context.SaveChanges();
        }
    }
}