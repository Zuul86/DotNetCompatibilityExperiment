using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NetCore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _config;

        public OrderRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<IEnumerable<CountryOrderResult>> GetOrderCountGroupedByCountry()
        {
            using (var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                return await conn.QueryAsync<CountryOrderResult>(@"SELECT ShipCountry AS CountryName, COUNT(ShipCountry) AS OrderCount
                                                                    FROM Orders
                                                                    GROUP BY ShipCountry
                                                                    ORDER BY COUNT(ShipCountry) DESC");
            }
        }
    }

    public class CountryOrderResult
    {
        public string CountryName { get; set; }
        public int OrderCount { get; set; }
    }
}