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
                        Type = "House",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false,
                        Difficulty = "High"
                    },

                    new Todo
                    {
                        Title = "Learn about context",
                        Type = "Outside",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false,
                        Difficulty = "High"
                    },

                    new Todo
                    {
                        Title = "Learn about context",
                        Type = "Coding",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false,
                        Difficulty = "High"
                    },

                    new Todo
                    {
                        Title = "Learn about context",
                        Type = "Coding",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false,
                        Difficulty = "High"
                    },

                    new Todo
                    {
                        Title = "Learn about context",
                        Type = "Boring",
                        DoneByDate = DateTime.Parse("30-08-21"),
                        IsCompleted = false,
                        Difficulty = "High"
                    }
                   );
                context.SaveChanges();
            }
        }
    }
}
