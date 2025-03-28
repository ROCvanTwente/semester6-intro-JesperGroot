using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace S6_ASPSEC_4.Controllers
{
    [Authorize(Roles = "I0SD3")]
    public class I0SD3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}