using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormODV.Models;

namespace FormODV.Controllers;

public class HomeController : Controller
{
    public IActionResult ShowMultipleViews()
    {
        return View("_Layout.cshtml");
    }

}
