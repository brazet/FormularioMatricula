using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace matricula.Models
{
    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Column("id")]
        public int Id { get; set; }
         [Column("apellidos")]
        public string apellidos{get;set;}
         [Column("nombres")]
        public string nombres{get;set;}
         [Column("fechanacimiento")]
        public DateTime fechanacimiento{get;set;}
         [Column("dni")]
        public string dni{get;set;}
         [Column("genero")]
        public string genero{get;set;}
         [Column("carrera")]
        public string carrera{get;set;}
        
    }
}