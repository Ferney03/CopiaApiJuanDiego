using LocalBackend.Data;
using LocalBackend.Repositories.Interfaces.Administracion;
using LocalShare.Responses;
using LocalShared.Entities.Administracion;
using LocalShared.Entities.Dispositivos;
using Microsoft.EntityFrameworkCore;

namespace LocalBackend.Repositories.implementation.Administracion
{
    public class ListaActividadesRepository : GenericRepository<ClsMListaActividades>, IListaActividadesRepository
    {
        private readonly DataContext _context;

        public ListaActividadesRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ActionResponse<ClsMListaActividades>> GetAsync(Guid id)
        {
            var ListaActividades = await _context.ListaActividades
                .Include(c => c.IdListaActividades!)
                .FirstOrDefaultAsync(c => c.IdListaActividades == id);
            if (ListaActividades == null)
            {
                return new ActionResponse<ClsMListaActividades>
                {
                    WasSuccess = false,
                    Message = "No existen registros de la actividad"
                };
            }

            return new ActionResponse<ClsMListaActividades>
            {
                WasSuccess = true,
                Result = ListaActividades
            };
        }

        public override async Task<ActionResponse<IEnumerable<ClsMListaActividades>>> GetAsync()
        {
            var ListaActividades = await _context.ListaActividades
                .Include(c => c.IdListaActividades)
                .ToListAsync();
            return new ActionResponse<IEnumerable<ClsMListaActividades>>
            {
                WasSuccess = true,
                Result = ListaActividades
            };
        }
    }
}
