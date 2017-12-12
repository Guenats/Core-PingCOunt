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
        public static int totalCount;
        public static Ping ping { get; set; } = new Ping();

        [HttpGet]
        public IActionResult Ping()
        {
            ping.Message = "pong";
            totalCount++;
            return new ObjectResult(ping);

        }
    }
}
