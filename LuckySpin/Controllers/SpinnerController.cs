using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        private readonly ILuckySpin _ls;

        public SpinnerController(ILuckySpin ls)
        {
            _ls = ls;
        }

        public IActionResult Index(int luck = 7)
        {
            return new ContentResult {Content = _ls.Output(luck), ContentType = "text/html"};
        }
    }
}