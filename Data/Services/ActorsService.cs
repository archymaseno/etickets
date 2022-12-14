
using etickets.Models;
using Microsoft.EntityFrameworkCore;

namespace etickets.Data.Services
{
    public class ActorsService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(results);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var AllActors = await _context.Actors.ToListAsync();
            return AllActors;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
