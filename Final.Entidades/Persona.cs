using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Entidades
{
    public class Persona
    {
        [Key]
        public int idpersona { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="El nombre de la persona debe tener más de 3 caracteres y menos de 100 caracteres")]
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        [StringLength(100,MinimumLength =3,ErrorMessage ="El apellido de la persona debe tener más de 3 caracteres y menos de 100 caracteres")]
        [DisplayName("Apellido")]
        public string apellido { get; set; }
        [DisplayName("Direccion")]
        public string direccion { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Telefono")]
        public string telefono { get; set; }
        [DisplayName("Correo")]
        public string correo { get; set; }

    }
}
