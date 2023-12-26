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
            FormModel.FormNames.Add("Form_1");
            FormModel.FormNames.Add("Form_2");
            FormModel.FormNames.Add("Form_3");
            FormModel.FormNames.Add("Form_4");
            FormModel.FormNames.Add("Form_5");
            FormModel.FormNames.Add("Form_6");
            FormModel.FormNames.Add("Form_7");
            FormModel.FormNames.Add("Form_8");
            FormModel.FormNames.Add("Form_9");
            FormModel.FormNames.Add("Form_10");


            return View(FormModel);
        }
        public IActionResult Form_1()
        {
            return View("Form_1");
        }
        public IActionResult Form_2()
        {
            return View("Form2");
        }
        public IActionResult Form_3()
        {
            return View("Form3");
        }
        public IActionResult Form_4()
        {
            return View("Form4");
        }
        public IActionResult Form_5()
        {
            return View("Form5");
        }
        public IActionResult Form_6()
        {
            return View("Form6");
        }
        public IActionResult Form_7()
        {
            return View("Form7");
        }
        public IActionResult Form_8()
        {
            return View("Form8");
        }
        public IActionResult Form_9()
        {
            return View("Form9");
        }
        public IActionResult Form_10()
        {
            return View("Form10");
        }
    }
}
