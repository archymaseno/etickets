using etickets.Data;
using etickets.Data.Services;
using etickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace etickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _service;
        public ActorsController(IActorService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var AllActors = await _service.GetAllAsync();
            return View(AllActors);
        }
        public IActionResult Create()
        {           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Details(int Id)
        {
            var ActorDetails = await _service.GetByIdAsync(Id);
            if (ActorDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(ActorDetails);
            }
        }
        public async Task<IActionResult> EditAsync(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(int id, Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }
       
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}