using BlazorAppTodo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTodo.AppContext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            

            dbContextOptionsBuilder.UseSqlServer("Data Source=.;Database=Test_DB_18;Trusted_Connection=true") ;
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}
