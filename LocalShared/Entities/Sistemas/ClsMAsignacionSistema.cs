using LocalShared.Entities.Administracion;
using System.ComponentModel.DataAnnotations;

namespace LocalShared.Entities.Sistemas
{
    public class ClsMAsignacionSistema
    {
        [Key]
        [Display(Name = "Identificador de asignacion")]
        public Guid IdAsignacionSistema { get; set; }

        //pendiente relacion
        public Guid? IdUpa { get; set; }
        public ClsMUpa? Upa { get; set; }

        public Guid? SistemaId { get; set; }
        public ClsMSistema? Sistema { get; set; }

        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public ICollection<ClsMPropiedadesSistema> propiedadesSistemas { get; set; }
    }
}
