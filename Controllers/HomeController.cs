using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormODV.Models;
using System.Collections.Generic;

namespace FormODV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var FormModel = new FormModel();
            FormModel.FormNames.Add("Form 1");
            FormModel.FormNames.Add("Form 2");
            FormModel.FormNames.Add("Form 3");
            FormModel.FormNames.Add("Form 4");
            FormModel.FormNames.Add("Form 5");
            FormModel.FormNames.Add("Form 6");
            FormModel.FormNames.Add("Form 7");
            FormModel.FormNames.Add("Form 8");
            FormModel.FormNames.Add("Form 9");
            FormModel.FormNames.Add("Form 10");
            return View(FormModel);
        }
    }
}
