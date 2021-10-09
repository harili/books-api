using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "First book title",
                        Description = "First book description",
                        Author = "Author First",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        DateAdded = DateTime.Now,
                        ConverUrl = "https"

                    },
                    new Book()
                    {
                        Title = "Second book title",
                        Description = "Second book description",
                        Author = "Author Second",
                        IsRead = false,
                        Genre = "Biography",
                        DateAdded = DateTime.Now,
                        ConverUrl = "https"

                    });

                    context.SaveChanges();
                }
            }

        }
    }
}
