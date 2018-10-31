using DotNetFourFiveTwo.Repositories;
using DotNetFourFiveTwo.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DotNetFourFiveTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderService _orderService;

        public HomeController()
        {
            _orderService = new OrderService(new OrderRepository());
        }

        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";

            var countryOrderResult = await _orderService.GetCountryOrderCountWithFlag();

            return View(countryOrderResult);
        }
    }
}
