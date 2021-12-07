using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.one = _context.Leagues.Where(l => l.Name.Contains("Womens")).ToList();
            ViewBag.two = _context.Leagues.Where(l => l.Sport.Contains("Hockey")).ToList();
            ViewBag.three = _context.Leagues.Where(l => !l.Sport.Contains("Football")).ToList();
            ViewBag.four = _context.Leagues.Where(l => l.Name.Contains("Conference")).ToList();
            ViewBag.five = _context.Leagues.Where(l => l.Name.Contains("Atlantic")).ToList();
            ViewBag.six = _context.Teams.Where(l => l.Location.Contains("Dallas")).ToList();
            ViewBag.seven = _context.Teams.Where(l => l.TeamName.Contains("Raptor")).ToList();
            ViewBag.eight = _context.Teams.Where(l => l.Location.Contains("City")).ToList();
            ViewBag.nine = _context.Teams.Where(l => l.TeamName.StartsWith("T")).ToList();
            ViewBag.ten = _context.Teams.OrderBy(l => l.Location).ToList();
            ViewBag.eleven = _context.Teams.OrderByDescending(l => l.Location).ToList();
            ViewBag.twelve = _context.Players.Where(l => l.LastName.Contains("Cooper")).ToList();
            ViewBag.thirteen = _context.Players.Where(l => l.FirstName.Contains("Joshua")).ToList();
            ViewBag.fourteen = _context.Players.Where(l => l.LastName.Contains("Cooper")&& !l.FirstName.Contains("Joshua")).ToList();
            ViewBag.fifteen = _context.Players.Where(l => l.FirstName.Contains("Alexander") || l.FirstName.Contains("Wyatt")).ToList();
            
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}