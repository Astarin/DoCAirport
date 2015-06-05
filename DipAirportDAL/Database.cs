using System.Data.Entity;
using DipAirportDOM;

namespace DipAirportDAL
{
    public class Database : DbContext , IDatabase
    {
        public IDbSet<AirportPersonel> AirportPersonels { get; set; }

        public Database()
        {
            System.Data.Entity.Database.SetInitializer(new AirportDataSeeder());
        }
    }
}
