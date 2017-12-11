using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PingCount.Models;
using SharpRaven.Data;
using SharpRaven;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PingCount.Controllers
{
    [Route("api/ping")]
    public class PingController : Controller
    {
        private readonly PingContext _context;

        public static Ping ping { get; set; } = new Ping();
        public PingController(PingContext context)
        {
            _context = context;

            if (_context.PingItems.Count() == 0)
            {
                _context.PingItems.Add(new Ping { Id = 01 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public string GetPing()
        {
            ping.Total++;
            return "pong";
        }
    }
}
