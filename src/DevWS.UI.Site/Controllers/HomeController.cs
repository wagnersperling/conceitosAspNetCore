using DevWS.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevWS.UI.Site.Controllers
{
    public class HomeController : Controller
    {

        //private readonly IPedidoRepository _pedidoRepository;

        //public HomeController(IPedidoRepository pedidoRepository)
        //{
        //    _pedidoRepository = pedidoRepository;
        //}

        public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
        {
            _pedidoRepository.ObterPedidos();
            return View();
        }
    }
}
