using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Administracion
{
    public class ClsMListaActividades
    {
        [Key]
        public Guid IdListaActividades { get; set; }
        public string? NombreActividad { get; set; }
        public string? Descripcion { get; set; }
        public string? Modulo { get; set; }
        public bool Estado { get; set; }
    }
}
