using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApiDemo1.Models;

namespace ToDoApiDemo1.Data
{
    public class ToDoApiDemo1Context : DbContext
    {
        public ToDoApiDemo1Context (DbContextOptions<ToDoApiDemo1Context> options)
            : base(options)
        {
        }

        public DbSet<ToDoApiDemo1.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
