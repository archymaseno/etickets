using etickets.Data;
using etickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace etickets.Controllers
{
    public class ProducersController : Controller
    {
        private AppDbContext _dbContex;
        public ProducersController(AppDbContext dbContext)
        {
            _dbContex = dbContext;
        }
        public IActionResult Index()
        {
            var AllProducers = _dbContex.Producers;
            if (AllProducers.Any())
            {
                return View(AllProducers);
            }
            return View("NotFound");
        }
        public IActionResult Details(int Id)
        {
            var result = _dbContex.Producers.FirstOrDefault(x => x.Id == Id);
            if (result == null)
            {
                return View("NotFound");
            }
            return View(result);
        }
        public IActionResult Create()
        {

        }
      
    }
}
