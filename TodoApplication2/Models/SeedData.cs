using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApplication2.Data;

namespace TodoApplication2.Models
{
    public class SeedData
    {
        public static object DateTimeTime { get; private set; }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TodoApplicationContext>>()))
            {
                if (context.Todo.Any())
                {
                    return;
                }

                context.Todo.AddRange(
                    new Todo
                    {
                        Title = "Learn about context",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false
                    },

                    new Todo
                    {
                        Title = "Learn about Database providers",
                        DoneByDate = DateTime.Parse("28-09-21"),
                        IsCompleted = false
                    },

                    new Todo
                    {
                        Title = "Learn more about C#",
                        DoneByDate = DateTime.Parse("30-12-21"),
                        IsCompleted = false
                    },

                    new Todo
                    {
                        Title = "Learn about Models",
                        DoneByDate = DateTime.Parse("28-09-21"),
                        IsCompleted = false
                    },

                    new Todo
                    {
                        Title = "Learn about Controllers",
                        DoneByDate = DateTime.Parse("28-09-21"),
                        IsCompleted = false
                    }
                   );
                context.SaveChanges();
            }
        }
    }
}
