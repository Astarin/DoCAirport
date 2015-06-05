using System;

namespace DipAirportAPI.ViewModels.AirportPersonel
{
    public interface IAirportPersonelView
    {
        string Lastname { get; set; }
        Guid Id { get; set; }
    }
}