namespace AuthorizationServer.Api.Migrations
{
    using AuthorizationServer.Api.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuthorizationServer.Api.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuthorizationServer.Api.Models.ApplicationDbContext context)
        {
            var manager = new UserManager<User>(new UserStore<User>(new ApplicationDbContext()));

            var user = new User()
            {
                UserName = "SuperAdmin",
                Email = "felipe.murillo@facturasiweb.com",
                EmailConfirmed = true,
                Name = "Admin",
                LastName = "Sistema",
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "MySuperP@ssword!");
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
        }
    }
}
