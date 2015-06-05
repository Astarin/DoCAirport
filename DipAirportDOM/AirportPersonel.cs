using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DipAirportDOM
{
    public class AirportPersonel : Entity, IAirportPersonel
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Adress { get; set; }

        public string AvatarUrl { get; set; }

        public string Jobdescription { get; set; }

        public string TelephoneNumber { get; set; }

        public DateTime? ChangedTime { get; private set ; }

        public void RecordLastSave()
        {
            ChangedTime = DateTime.Now;
        }

        public void EditAirPortPersonel(IAirportPersonel editPersonel)
        {
            Firstname = editPersonel.Firstname;
            Lastname = editPersonel.Lastname;
            Adress = editPersonel.Adress;
        }

        public AirportPersonel()
        {
            
        }
    }
}
