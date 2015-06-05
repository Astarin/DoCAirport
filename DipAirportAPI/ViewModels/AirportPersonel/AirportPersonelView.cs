using System;

namespace DipAirportAPI.ViewModels.AirportPersonel
{
    public class AirportPersonelView : IAirportPersonelView
    {
        public string Lastname { get; set; }

        public Guid Id { get; set; }
    }
}