using CountryFlag;
using NetCore.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IFlagLoader _flagLoader;

        public OrderService(IOrderRepository orderRepository, IFlagLoader flagLoader)
        {
            _orderRepository = orderRepository;
            _flagLoader = flagLoader;
        }

        public async Task<IEnumerable<CountryOrderFlag>> GetCountryOrderCountWithFlag()
        {
            var result = await _orderRepository.GetOrderCountGroupedByCountry();

            return result.Select(x => new CountryOrderFlag { CountryName = x.CountryName, OrderCount = x.OrderCount, FlagUrl = _flagLoader.GetFlagUrlByCountryName(x.CountryName) });
        }
    }

    public class CountryOrderFlag
    {
        public string CountryName { get; set; }
        public int OrderCount { get; set; }
        public string FlagUrl { get; set; }
    }
}