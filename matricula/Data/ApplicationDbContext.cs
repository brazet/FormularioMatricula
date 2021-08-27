using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace matricula.Data
{
    public class AplicationDbContext:IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        : base(options)
        {

        } 
        public DbSet<matricula.Models.Alumno> DataAlumnos {get;set;}
        
    }
}