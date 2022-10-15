using etickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace etickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;
        public MoviesController(AppDbContext _context)
        {
            context = _context; 
        }
        public async Task<IActionResult> Index()
        {
            var AllMovies =await context.Movies.Include(n=>n.Cinema).OrderBy(o=>o.Name).ToListAsync();
            return View(AllMovies);
        }
    }
}
