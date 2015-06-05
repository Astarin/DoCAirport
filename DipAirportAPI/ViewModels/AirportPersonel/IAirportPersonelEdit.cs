using System;
using DipAirportDOM;

namespace DipAirportAPI.ViewModels.AirportPersonel
{
    public interface IAirportPersonelEdit : IEntity
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Adress { get; set; }
        DateTime? ChangedTime { get; }
        string AvatarUrl { get; set; }
        string Jobdescription { get; set; }
        string TelephoneNumber { get; set; }

       void EditAirPortPersonel(IAirportPersonel editPersonel);
    }
}