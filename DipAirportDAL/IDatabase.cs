using System.Data.Entity;
using DipAirportDOM;

namespace DipAirportDAL
{
    public interface IDatabase
    {
        IDbSet<AirportPersonel> AirportPersonels { get; set; }
    }
}
