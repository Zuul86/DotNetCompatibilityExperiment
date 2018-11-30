using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<CountryOrderResult>> GetOrderCountGroupedByCountry();
    }
}