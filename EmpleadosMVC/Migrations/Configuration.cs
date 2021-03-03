namespace EmpleadosMVC.Migrations
{
    using EmpleadosMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmpleadosMVC.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EmpleadosMVC.Models.EmpleadoDBContext";
        }

        protected override void Seed(EmpleadosMVC.Models.EmpleadoDBContext context)
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

            context.Empleados.AddOrUpdate(i => i.Nombre, new Empleado
            {
             Nombre = "Matilda",
             Antiguedad=10,
             Edad=30,
             Categoria="A"
            
            }, new Empleado {
                Nombre = "Carla",
                Antiguedad = 10,
                Edad = 40,
                Categoria="A"
            }
             );



        }
    }
}
