using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EmpleadosMVC.Models
{
    public class Empleado
    {
        
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required]
        [Range(1,40)]
        public int Antiguedad { get; set; }

        [Required]
        [Range(18, 65)]
        public int Edad { get; set; }

        [Required]
        public string Categoria { get; set; }
    }

    public class  EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}