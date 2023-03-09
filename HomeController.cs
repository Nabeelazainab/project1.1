using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project2.Models;

namespace project2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ActionResult AboutUs()
    {


        return View();
    }

    public ActionResult ContactUs()
    {


        return View();
    }

    public ActionResult CorporateProfile()
    {


        return View();
    }

    public ActionResult oneone()
    {


        return View();
    }
    public ActionResult Twotwoo()
    {


        return View();
    }
    public ActionResult Threethreee()
    {


        return View();
    }

    public ActionResult Fourfourr()
    {


        return View();
    }

    public ActionResult Fivefivee()
    {


        return View();
    }
    public ActionResult Sixsixx()
    {


        return View();
    }
    public ActionResult Sevensevenn()
    {


        return View();
    }
    public ActionResult Eighteightt()
    {


        return View();
    }
    public ActionResult Nineninee()
    {


        return View();
    }
    public ActionResult Tentenn()
    {


        return View();
    }

    public ActionResult one()
    {


        return View();
    }
    public ActionResult Two()
    {


        return View();
    }
    public ActionResult Three()
    {


        return View();
    }

    public ActionResult Four()
    {


        return View();
    }

    public ActionResult Five()
    {


        return View();
    }
    public ActionResult Six()
    {


        return View();
    }
    public ActionResult Seven()
    {


        return View();
    }
    public ActionResult Eight()
    {


        return View();
    }
    public ActionResult Nine()
    {


        return View();
    }
    public ActionResult Ten()
    {


        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

