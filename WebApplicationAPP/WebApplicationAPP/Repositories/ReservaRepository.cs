using WebApplicationAPP.Data;
using WebApplicationAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPP.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AppDbContext _context;

        public ReservaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Reserva BuscarPorId(int id)
        {
            var reserva = (from r in _context.Reservas
                           join s in _context.Set<dynamic>("SERVICIOS")
                           on r.IdServicio equals s.Id
                           where r.Id == id
                           select new Reserva
                           {
                               Id = r.Id,
                               NombreDelAsociado = r.NombreDelAsociado,
                               Telefono = r.Telefono,
                               Correo = r.Correo,
                               Identificacion = r.Identificacion,
                               FechaNacimiento = r.FechaNacimiento,
                               Direccion = r.Direccion,
                               MontoTotal = r.MontoTotal,
                               FechaDelServicio = r.FechaDelServicio,
                               FechaDeRegistro = r.FechaDeRegistro,
                               NombreServicio = s.Nombre,
                               AreaServicio = s.AreaServicio,
                               Encargado = s.Encargado
                           }).FirstOrDefault();

            return reserva;
        }
    }
}
