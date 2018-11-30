using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCore.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<CountryOrderFlag>> GetCountryOrderCountWithFlag();
    }
}