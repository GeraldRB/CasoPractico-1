using Microsoft.AspNetCore.Mvc;

public class ReservaAdminController : Controller
{
    private readonly ReservaBussines _bussines;

    public ReservaAdminController(ReservaBussines bussines)
    {
        _bussines = bussines;
    }

    public IActionResult Historial(int? idServicio)
    {
        if (idServicio.HasValue)
        {
            var lista = _bussines.GetByServicio(idServicio.Value);
            return View(lista);
        }

        return View(_bussines.GetAll());
    }
}
