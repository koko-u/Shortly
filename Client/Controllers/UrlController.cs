using Microsoft.AspNetCore.Mvc;

namespace Shortly.Client.Controllers;

public class UrlController : Controller
{
    // GET: UrlController
    public ActionResult Index()
    {
        return View();
    }

}
