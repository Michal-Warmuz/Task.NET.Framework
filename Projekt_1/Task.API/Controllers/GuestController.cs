using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Task.Infrastructure.Services.Interface;

namespace Task.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GuestController : ApiController
    {
        public readonly IGuestService guestService;

        public GuestController(IGuestService _guestService)
        {
            guestService = _guestService;
        }


        [HttpGet]
        [Route("GetPeters")]
        public IHttpActionResult GetPeters()
        {
            return Json(guestService.GetPeters());
        }
    }
}
