using Raaj.Application.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Raaj.Application.Context
{
    public class RaajDbConnection:DbContext
    {  
        public RaajDbConnection() : base("DefaultConnection")
        {

        }
          public DbSet<Student> Students { get; set; }
          public DbSet<Course> Courses { get; set; }
          public DbSet<Facilitator> Facilitators { get; set; }
          public DbSet<Employee> Employees { get; set; }
          public DbSet<Manager> Managers { get; set; } 
    }
}