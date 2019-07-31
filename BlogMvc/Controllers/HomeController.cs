using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogMvc.Models;
using BlogMvc.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace BlogMvc.Controllers
{
    public class HomeController : Controller
    {

        private readonly BlogMvcContext _context;

        public HomeController(BlogMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Articles = _context.Article
                                    .Include(i => i.ArticleTags)
                                    .ThenInclude(i => i.Tag)
                                    .ToList();
            model.Categories = _context.Categories.ToList();
            return View(model);
        }

        public IActionResult LoginUser()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}





