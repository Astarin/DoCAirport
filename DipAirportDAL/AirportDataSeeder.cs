using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DipAirportDOM;

namespace DipAirportDAL
{
    public class AirportDataSeeder : DropCreateDatabaseIfModelChanges<Database>
    {
        protected override void Seed(Database context)
        {
            List<AirportPersonel> personels = new List<AirportPersonel>()
            {
                new AirportPersonel()
                {
                    Firstname = "Derek",
                    Lastname = "Patterson",
                    Adress = "Hikstraat 19A",
                    AvatarUrl = @"\images\Avatars\1.jpg"
                    
                },
                new AirportPersonel()
                {
                    Firstname = "Raul",
                    Lastname = "Chandler",
                    Adress = "Hikstraat 19B",
                    AvatarUrl = @"\images\Avatars\2.jpg"
                },
                new AirportPersonel()
                {
                    Firstname = "Eduardo",
                    Lastname = "Gilbert",
                    Adress = "Hikstraat 19C",
                      AvatarUrl = @"\images\Avatars\3.jpg"
                },
                  new AirportPersonel()
                {
                    Firstname = "Amber",
                    Lastname = "Peterson",
                    Adress = "Hikstraat 19D",
                      AvatarUrl = @"\images\Avatars\4.jpg"
                },
                  new AirportPersonel()
                {
                    Firstname = "Simon",
                    Lastname = "Pearson",
                    Adress = "Hikstraat 19E",
                      AvatarUrl = @"\images\Avatars\5.jpg"
                },
                  new AirportPersonel()
                {
                    Firstname = "Rachael",
                    Lastname = "Gill",
                    Adress = "Hikstraat 19F",
                      AvatarUrl = @"\images\Avatars\6.jpg"
                }
            };
            foreach (AirportPersonel airportPersonel in personels)
            {
                context.AirportPersonels.Add(airportPersonel);
            }

            context.SaveChanges();
        }
    }
}
