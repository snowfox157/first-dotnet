using Microsoft.AspNetCore.Mvc;
namespace YourApp.Controllers
{
    [Route("demo")]
    public class demoController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Detail(int id)
        {
            // return View();
            return Content($"demo ID: : {id}");
        }
   }

}