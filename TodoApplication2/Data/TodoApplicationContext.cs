using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApplication2.Models;

namespace TodoApplication2.Data
{
    public class TodoApplicationContext : DbContext
    {
        public TodoApplicationContext (DbContextOptions<TodoApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApplication2.Models.Todo> Todo { get; set; }
    }
}
