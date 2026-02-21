using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;

public class ReservaController : Controller
{
    private readonly ReservaBussines _bussines;

    public ReservaController(ReservaBussines bussines)
    {
        _bussines = bussines;
    }

    public IActionResult Buscar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Buscar(int id)
    {
        var reserva = _bussines.Buscar(id);

        if (reserva == null)
        {
            ViewBag.Mensaje =
            "Estimado asociado, no se ha encontrado la reserva, favor realizar una nueva.";

            return View();
        }

        return View("Detalle", reserva);
    }
}
