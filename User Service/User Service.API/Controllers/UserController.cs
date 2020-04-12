using Microsoft.AspNetCore.Mvc;

namespace User_Service.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context){
            _context = context;
        }
        [HttpGet]
        [Route("{controller}/{id}")]
        public JsonResult Get(int id){

            var user = _context.Users
                                  .Find(1);
                                  
            return new JsonResult(user);
        }
    }
}