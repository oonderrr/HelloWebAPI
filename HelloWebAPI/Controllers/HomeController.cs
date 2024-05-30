using HelloWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ResponseModel GetMessage()
        {
            return new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Hello Web API"
            };
        }
    }
}