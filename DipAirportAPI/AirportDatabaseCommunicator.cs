using System.Collections.Generic;
using System.Linq;
using DipAirportAPI.ViewModels.AirportPersonel;
using DipAirportDAL;
using DipAirportDOM;

namespace DipAirportAPI
{
    public class AirportDatabaseCommunicator
    {
        private Database _database;

        public AirportDatabaseCommunicator()
        {
            _database = new Database();
        }

        public void EditAirportPersonel(IAirportPersonelEdit person)
        {
            IAirportPersonel personToEdit = _database.AirportPersonels.FirstOrDefault(a => a.Id == person.Id);
            person.EditAirPortPersonel(personToEdit); // person should be editited now.

            personToEdit.RecordLastSave();
            _database.SaveChanges();
        }

        //....

        public IAirportPersonelEdit GetAirportPersonel(IAirportPersonelView entity) // Inversion of control. 
        {
            return AutoMapper.Mapper.Map<AirportPersonelEdit>(_database.AirportPersonels.FirstOrDefault(a => a.Id == entity.Id));
        }

        public IEnumerable<IAirportPersonelView> GetAllAirportPersonel()
        {
            var airportPersonel= _database.AirportPersonels.OfType<AirportPersonel>().ToList();

            foreach (IAirportPersonel  person in airportPersonel)
            {
                yield return new AirportPersonelView(){Id = person.Id, Lastname = person.Lastname};
            }
        }

      
    }
}
