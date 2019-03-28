using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2Project.Models;
using Core2Project.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core2Project.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class TimeTravelController : ControllerBase
    {

        private ITimeTravelServices _services;
        public TimeTravelController(ITimeTravelServices services)
        {
            _services = services;
        }
        [HttpPost]
        [Route("AddTimeTravelItems")]
        public ActionResult<TimeTravelItems> AddTimeTravelItems(TimeTravelItems items)
        {
            var timetravelItems = _services.AddTimeTravelItems(items);
            if (timetravelItems == null) return NotFound();
            return timetravelItems;
        }
        [HttpGet]
        [Route("GetTimeTravelItems")]
        public ActionResult<Dictionary<string, TimeTravelItems>> GetTimeTravelItems()
        {
            var timetravelItems = _services.GetTimeTravelItems();

            if (timetravelItems.Count == 0) return NotFound();
            return timetravelItems;
        }
    }
}