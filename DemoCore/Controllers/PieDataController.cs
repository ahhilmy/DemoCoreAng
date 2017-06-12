using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCore.Models;

namespace DemoCore.Controllers
{
    [Produces("application/json")]
    [Route("api/PieData")]
    public class PieDataController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieDataController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IEnumerable<Pie> LoadMorePies()
        {
            IEnumerable<Pie> dbPies = null;

            dbPies = _pieRepository.Pies.OrderBy(p => p.PieId).Take(10);

            //can be mapped into view model if required

            return dbPies;
        }
    }
}