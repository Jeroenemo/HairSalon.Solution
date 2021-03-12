using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    public actionResult Index()
    {
      return View();
    }
  }
}