using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Administracion
{
    public class ClsMUsuario
    {
        [Key]
        public Guid IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Contrasena { get; set; }
        public bool Estado { get; set; }
        public Guid UpaId { get; set; }
        public ClsMUpa Upa { get; set; }
        public int NumIntentos { get; set; }
    }
}
