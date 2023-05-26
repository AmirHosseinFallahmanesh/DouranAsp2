using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo1.Models;
using Demo1.DAL;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DemoContext context;

        public HomeController(DemoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {

            HomeViewModel vm = new HomeViewModel();
            vm.LastNews = context.News.Where(a => !a.HotNews).OrderByDescending(a => a.InsertTime).ToList();
            vm.HotNews = context.News.Where(a => a.HotNews).OrderByDescending(a => a.InsertTime).ToList();
            vm.Ads = context.Ads.ToList();
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
