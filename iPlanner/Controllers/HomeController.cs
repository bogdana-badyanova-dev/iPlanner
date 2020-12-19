using iPlanner.Data;
using iPlanner.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace iPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly iPlannerContext _context;

        public HomeController(iPlannerContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            dynamic dy = new ExpandoObject();
            dy.boardsList = boards();
            dy.cardsList = cards();
            return View(dy);
        }
        public List<Board> boards()
        {
            return _context.Board.ToList();
        }
        public List<Card> cards()
        {
            return _context.Card.ToList();
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
