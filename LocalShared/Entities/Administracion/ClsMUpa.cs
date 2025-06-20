using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Administracion
{
    public class ClsMUpa
    {
        [Key]
        public Guid IdUpa { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public bool Estado { get; set; }
    }
}
