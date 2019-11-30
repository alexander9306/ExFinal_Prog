using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Entidades
{
    public class Visita
    {

     
        [Key]
        public int idvisita { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha")]
        public DateTime fecha { get; set; }
        [DisplayName("Hora de entrada")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [Required(ErrorMessage = "El formato para la hora es HH/MM/PM")]
        public TimeSpan hora_entrada { get; set; } 
        [DisplayName("Hora de salida")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}")]
        [Required(ErrorMessage = "El formato para la hora es HH/MM/PM")]
        public TimeSpan hora_salida { get; set; }
        [DisplayName("Persona")]
        public string Persona { get; set; }
        public ICollection<Persona> personas { get; set; }
        public ICollection<Departamento> departamento { get; set; }
        [DisplayName("Motivo")]
        public string motivo { get; set; }
    }
}
