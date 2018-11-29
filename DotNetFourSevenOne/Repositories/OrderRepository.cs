using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DotNetFourSevenOne.Repositories
{
    public class OrderRepository
    {
        public async Task<IEnumerable<CountryOrderResult>> GetOrderCountGroupedByCountry()
        {
            using(var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
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