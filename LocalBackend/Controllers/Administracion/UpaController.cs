using LocalBackend.Repositories.UnitsOfWork.Interfaces;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Administracion;
using LocalBackend.Repositories.UnitsOfWork.Interfaces.Dispositivos;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;
using Microsoft.AspNetCore.Mvc;

namespace LocalBackend.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpaController : GenericController<ClsMUpa>
    {
        private readonly IUpaUnitOfWork _upaUnitOfWork;

        public UpaController(IGenericUnitOfWork<ClsMUpa> unitOfWork, IUpaUnitOfWork upaUnitOfWork) : base(unitOfWork)
        {
            _upaUnitOfWork = upaUnitOfWork;
        }

        [HttpGet("full")]
        public override async Task<IActionResult> GetAsync()
        {
            var responce = await _upaUnitOfWork.GetAsync();
            if (responce.WasSuccess)
            {
                return Ok(responce.Result);
            }
            return BadRequest();
        }
    }

    

}