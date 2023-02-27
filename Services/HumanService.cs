using Microsoft.EntityFrameworkCore;
using WebApplication1.Db;

namespace WebApplication1.Services
{
    public class HumanService : IHumanService
    {
        private static List<Human> H = new List<Human>
         {
             new Human { id= 310111, Name = "hmed" , Adress = "ALG" },
             new Human { id= 310112, Name = "hme" , Adress = "AG" },
             new Human { id = 310113, Name = "med", Adress = "LG" }
         };
        private readonly DataContext _context;

        public HumanService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Human>> DeleteHuman(int id)
        {
            Human h = await _context.Human.FindAsync(id);
            if (h is null) { return null; }
             _context.Human.Remove(h);
            await _context.SaveChangesAsync();
            return await _context.Human.ToListAsync();
        }
        public async Task<List<Human>> GetALL()
        {
            var humans = await _context.Human.ToListAsync();
            return humans;
        }

        public async Task<Human> GetSingal(int id)
        {
            var OneHuman = await _context.Human.FindAsync(id);
            if (OneHuman is null)
            {
                return null;
            }
            return  OneHuman;
        }
        public async Task<List<Human>> PostHuman(Human human)
        {
            _context.Human.Add(human);
             await _context.SaveChangesAsync();
            return await _context.Human.ToListAsync();
        }

        public async Task<List<Human>> UpdateSingal(int id, Human req)
        {
            var OneHuman = await _context.Human.FindAsync(id);
            if (OneHuman is null)
            {
                return null;
            }
            OneHuman.id = req.id;
            OneHuman.Name = req.Name;
            OneHuman.Adress = req.Adress;

            await _context.SaveChangesAsync();

            return await _context.Human.ToListAsync();
        }


    }
}
