using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalShared.Entities.Administracion
{
    public class ClsMAsignacionActividad
    {
        [Key]
        public Guid IdAsignacionActividad { get; set; }
        public Guid ActividadId { get; set; }
        public ClsMListaActividades Actividad { get; set; }
        public Guid ActividadUsuarioId { get; set; }
        public ClsMUsuario ActividadUsuario { get; set; }
        public bool EstadoAsignacion { get; set; }
    }
}
