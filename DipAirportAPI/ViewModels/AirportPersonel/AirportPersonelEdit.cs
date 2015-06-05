using System;
using DipAirportDOM;

namespace DipAirportAPI.ViewModels.AirportPersonel
{
    public class AirportPersonelEdit : IAirportPersonelEdit
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Adress { get; set; }

        public DateTime? ChangedTime { get; private set; }

        public string AvatarUrl { get; set; }

        public string Jobdescription { get; set; }

        public string TelephoneNumber { get; set; }
        public void  EditAirPortPersonel(IAirportPersonel editPersonel)
        {
            editPersonel.Firstname = Firstname;
            editPersonel.Lastname = Lastname;
            editPersonel.Adress = Adress;
            editPersonel.Jobdescription = Jobdescription;
            editPersonel.TelephoneNumber = TelephoneNumber;
        }

        public AirportPersonelEdit()
        {
            
        }
    }
}
