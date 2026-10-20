
using Microsoft.AspNetCore.Mvc;

namespace Bai_2__N20_11_.ViewComponents
{
    public class ChaoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string ten)
        {
            return View("Default", ten);
        }
    }
}
