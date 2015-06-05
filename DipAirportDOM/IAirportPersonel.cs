using System;

namespace DipAirportDOM
{
    public interface IAirportPersonel : IEntity
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Adress { get; set; }
        DateTime? ChangedTime { get; }
        string AvatarUrl { get; set; }
        string Jobdescription { get; set; }
        string TelephoneNumber { get; set; }

        void RecordLastSave();

    
    }
}
