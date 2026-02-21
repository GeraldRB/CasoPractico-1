using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ReservaBussines
    {
        private readonly IReservaRepository _repository;

        public ReservaBussines(IReservaRepository repository)
        {
            _repository = repository;
        }

        public Reserva Buscar(int id)
        {
            return _repository.BuscarPorId(id);
        }
    }
}
