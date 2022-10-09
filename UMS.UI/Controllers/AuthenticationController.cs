using Microsoft.AspNetCore.Mvc;

namespace UMS.UI.Controllers
{
    [Route("auth")]
    public class AuthenticationController : Controller
    {
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
