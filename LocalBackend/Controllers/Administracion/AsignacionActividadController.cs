using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalShared.Entities.Administracion;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsignacionActividadController : GenericController<ClsMAsignacionActividad>
    {
        public AsignacionActividadController(IGenericUnitOfWork<ClsMAsignacionActividad> unitOfWork) : base(unitOfWork)
        {
        }
    }
}