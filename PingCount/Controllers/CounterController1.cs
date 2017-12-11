using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PingCount.Controllers
{
    [Route("api/count")]
    public class CounterController1 : Controller
    {

        [HttpGet]
        public int Get()
        {
            return PingController.ping.Total;
        }
    }
}
