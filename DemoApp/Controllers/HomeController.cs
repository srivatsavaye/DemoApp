using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoLibrary;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var parts = new List<DocumentPart> 
            { 
                new PlainText("This is Plain text"),
                new BoldText("This is Bold Text"),
                new Hyperlink("This is a Hyperlink","www.google.com")
            };
            var document = new Document(parts);
			ViewData["Html"] = document.ToHtml();
			ViewData["PlainText"] = document.ToPlainText();
			ViewData["Latex"] = document.ToLatex();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
