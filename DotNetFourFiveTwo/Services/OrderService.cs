using DotNetFourFiveTwo.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFourFiveTwo.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<CountryOrderFlag>> GetCountryOrderCountWithFlag()
        {
            var result = await _orderRepository.GetOrderCountGroupedByCountry();

            return result.Select(x => new CountryOrderFlag { CountryName = x.CountryName, OrderCount = x.OrderCount, FlagUrl = "" });
        }
    }

    public class CountryOrderFlag
    {
        public string CountryName { get; set; }
        public int OrderCount { get; set; }
        public string FlagUrl { get; set; }
    }
}