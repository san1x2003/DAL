using Sanshop.Models;

namespace Sanshop.Services.ZakazServices
{
    public class ZakazService : IZakazService
    {

        private readonly DataContext _context;

        public ZakazService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Zakaz>> AddZakaz(Zakaz oneZakaz)
        {
            _context.Zakaz.Add(oneZakaz);

            await _context.SaveChangesAsync();

            return await _context.Zakaz.ToListAsync();
        }

        public async Task<List<Zakaz>?> DeleteZakaz(int id)
        {
            var oneZakaz = await _context.Zakaz.FindAsync(id);
            if (oneZakaz is null)
                return null;

            _context.Zakaz.Remove(oneZakaz);

            await _context.SaveChangesAsync();


            return await _context.Zakaz.ToListAsync();
        }

        public async Task<List<Zakaz>> GetAllZakaz()
        {
            var clients = await _context.Zakaz.ToListAsync();
            return clients;
        }

        public async Task<Zakaz?> GetSingleZakaz(int id)
        {
            var oneZakaz = await _context.Zakaz.FindAsync(id);
            if (oneZakaz is null)
                return null;
            return oneZakaz;
        }

        public async Task<List<Zakaz>?> UpdateZakaz(int id, Zakaz request)
        {
            var oneZakaz = await _context.Zakaz.FindAsync(id);
            if (oneZakaz is null)
                return null;

            oneZakaz.Id = request.Id;
            oneZakaz.NumberContact = request.NumberContact;
            oneZakaz.OrderDate = request.OrderDate;
            oneZakaz.Data = request.Data;           

            await _context.SaveChangesAsync();

            return await _context.Zakaz.ToListAsync();
        }
    }
}
