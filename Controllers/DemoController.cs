using Microsoft.AspNetCore.Mvc;
using DotnetFirst.Models;
using DotnetFirst.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace DotnetFirst.Controllers
{
    [Route("demo")]
    public class demoController : Controller
    {
        private readonly IUserService _userService;

        public demoController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            // var user = _userService.GetUserById(1);
            return Content("無什麼特別的");
            // return Content(user);
        }
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            // return View();
            var user = _userService.GetUserById(id);
            var name = "";
            if (user != null)
            {
                name = user?.Name;
            }
            else
            {
                name = "no name";
            }
            return Content($"demo ID: : {id}; name : {name}");
        }
   }

}