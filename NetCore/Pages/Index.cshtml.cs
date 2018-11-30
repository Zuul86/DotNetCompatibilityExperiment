using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCore.Repositories;
using NetCore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOrderService _orderService;

        public IndexModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IEnumerable<CountryOrderFlag> CountryOrderFlags { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            CountryOrderFlags = await _orderService.GetCountryOrderCountWithFlag();
            return Page();
        }
    }
}