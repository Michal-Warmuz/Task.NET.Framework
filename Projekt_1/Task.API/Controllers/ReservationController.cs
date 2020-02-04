using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Task.Infrastructure.Commands;
using Task.Infrastructure.Services.Interface;

namespace Task.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReservationController : ApiController
    {
        public readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            var payload = reservationService.GetAll();
            return Json(payload);
        }


        [HttpPost]
        [Route("SaveReservationWithGuests")]
        public IHttpActionResult SaveReservationWithGuests([FromBody]ReservationWithGuestsCommand command)
        {
            try
            {
                reservationService.SaveReservationWithGuests(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
