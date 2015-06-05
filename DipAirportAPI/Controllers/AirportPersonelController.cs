using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DipAirportAPI.ViewModels.AirportPersonel;
using DipAirportDAL;
using DipAirportDOM;

namespace DipAirportAPI.Controllers
{
    [OverrideAuthentication]
    [OverrideAuthorization]
    [EnableCors(origins: "http://localhost:2056", headers: "*", methods: "*")]
    [RoutePrefix("api/airportPersonel")]
    public class AirportPersonelController : ApiController
    {
        private readonly AirportDatabaseCommunicator dbCommunicator;
        public AirportPersonelController()
        {
            dbCommunicator = new AirportDatabaseCommunicator();
        }

        [Route("all")]
        [HttpGet]
        public IEnumerable<IAirportPersonelView> GetAllAirportPersonel()
        {
            return dbCommunicator.GetAllAirportPersonel();
        }

        [Route("persondetail")]
        [HttpPost]
        public IAirportPersonelEdit GetAirportPersonel(AirportPersonelView person)
        {
            return dbCommunicator.GetAirportPersonel(person);
        }

        [Route("editperson")]
        [HttpPut]
        public HttpResponseMessage PutAirportPersonel(AirportPersonelEdit person)
        {
            try
            {
                dbCommunicator.EditAirportPersonel(person);
            }
            catch (Exception)
            {
               return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            
            return new HttpResponseMessage(HttpStatusCode.OK);
        } 
    }
}
