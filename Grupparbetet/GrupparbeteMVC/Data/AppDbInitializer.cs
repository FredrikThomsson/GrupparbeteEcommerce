using GrupparbeteMVC.Models;

namespace GrupparbeteMVC.Data

{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationContext>();

                context.Database.EnsureCreated();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Test",
                            Description= "Test",
                            SEKPrice = 100,
                            DollarPrice= 10,
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }


}

