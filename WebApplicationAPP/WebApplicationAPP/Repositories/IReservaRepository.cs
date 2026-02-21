using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IReservaRepository
    {
        Reserva BuscarPorId(int id);
    }
}
