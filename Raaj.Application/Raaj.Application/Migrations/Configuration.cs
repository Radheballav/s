namespace Raaj.Application.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Raaj.Application.Context.AppDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Raaj.Application.Context.AppDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Student> StudentList = new List<Student>()
            {
                new Student()
                {
                    Firstname="Ramesh",
                    Lastname="Joshi",
                    Email="ramesh@gmail.com",
                    Contactnumner="12323232",
                    Address="patan",
                    Status=true
                },
                new Student()
                {
                    Firstname="Rajesh",
                    Lastname="Thapa",
                    Email="rajrsh@gmail.com",
                    Contactnumner="124242",
                    Address="ktm",
                    Status=false

                }
            };
            StudentList.ForEach(s =>
            {
               context.Students.Add(s);
                context.SaveChanges();
            });
            List<Course> Courselist = new List<Course>()
               {
                   new Course()
                   {
                       Name="asp.net",
                       Description="asp.net",
                       JoinDate=DateTime.Now,
                       ModifiedDate=null,
                       Status=true,
                   },
                    new Course()
                    {
                        Name="pythen",
                        Description="pythen",
                        JoinDate=21.,
                        ModifiedDate=null,
                        Status=true


                    }

               };
            Courselist.ForEach>
            {
                context.Courses.Add(c);
                context.Savechanges();

            });
              
        }


    }
}

