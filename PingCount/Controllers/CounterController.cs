using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PingCount.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PingCount.Controllers
{
    [Route("api/count")]
    public class CounterController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            Counter count = new Counter();
            count.TotalPing = PingController.totalCount;
            return new ObjectResult(count) ;
        }
    }
}
