using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Entidades
{
    public class Departamento
    {
        [Key]
        public int iddepartamento { get; set; }
        [DisplayName("Nombre")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="El nombre de la persona debe tener más de 3 caracteres y menos de 100 caracteres")]
        public string nombre { get; set; }
        [DisplayName("Estado")]
        public bool estado { get; set; }
    }
}
