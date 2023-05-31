using Sanshop.Models;

namespace Sanshop.Services.TovarServices
{
    public class TovarService : ITovarService
    {

        private readonly DataContext _context;

        public TovarService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Tovar>> AddTovar(Tovar oneTovar)
        {
            _context.Tovar.Add(oneTovar);

            await _context.SaveChangesAsync();

            return await _context.Tovar.ToListAsync();
        }

        public async Task<List<Tovar>?> DeleteTovar(int id)
        {
            var oneTovar = await _context.Tovar.FindAsync(id);
            if (oneTovar is null)
                return null;

            _context.Tovar.Remove(oneTovar);

            await _context.SaveChangesAsync();


            return await _context.Tovar.ToListAsync();
        }

        public async Task<List<Tovar>> GetAllTovar()
        {
            var tovars = await _context.Tovar.ToListAsync();
            return tovars;
        }

        public async Task<Tovar?> GetSingleTovar(int id)
        {
            var oneTovar = await _context.Tovar.FindAsync(id);
            if (oneTovar is null)
                return null;
            return oneTovar;
        }

        public async Task<List<Tovar>?> UpdateTovar(int id, Tovar request)
        {
            var oneTovar = await _context.Tovar.FindAsync(id);
            if (oneTovar is null)
                return null;

            oneTovar.Id = request.Id;
            oneTovar.Name = request.Name;
            oneTovar.Price = request.Price;
            oneTovar.DeliveryTime = request.DeliveryTime;

            await _context.SaveChangesAsync();

            return await _context.Tovar.ToListAsync();
        }
    }
}
