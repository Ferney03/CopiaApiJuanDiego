using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Administracion;
using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Administracion
{
    public class AsignacionActividadRepository : GenericRepository<ClsMAsignacionActividad>, IAsignacionActividadRepository
    {
        private readonly DataContext _context;

        public AsignacionActividadRepository(DataContext context): base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMAsignacionActividad>> GetAsync(Guid id)
        {
            var AsignacionActvidad = await _context.AsignacionActividad
                .Include(c => c.ActividadUsuario!)
                .FirstOrDefaultAsync(c => c.IdAsignacionActividad == id);
            if (AsignacionActvidad == null)
            {
                return new ActionResponse<ClsMAsignacionActividad>
                {
                    WasSuccess = false,
                    Message = "No existen registros de la actividad"
                };
            }

            return new ActionResponse<ClsMAsignacionActividad>
            {
                WasSuccess = true,
                Result = AsignacionActvidad
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMAsignacionActividad>>> GetAsync()
        {
            var Asignacionactividad = await _context.AsignacionActividad
                .Include(c => c.ActividadUsuario)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMAsignacionActividad>>
            {
                WasSuccess = true,
                Result = Asignacionactividad
            };
        }
    }   
}
