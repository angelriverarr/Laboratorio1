using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Angel_lab1.Models
{
    public class Estudiante
    {

        public String Nombre { get; set;}
        public float  Laboratorio1 { get; set; }
        public float Laboratorio2 { get; set; }
        public float Laboratorio3 { get; set; }

        public float Parcial1 { get; set; }
        public float Parcial2 { get; set; }
        public float Parcial3 { get; set; }

    }
    public class EstuDBContex : DbContext {
        public EstuDBContex()
        {       
          }
        public DbSet<Estudiante> Estudiantes { get; set; }
    {>

    }

}