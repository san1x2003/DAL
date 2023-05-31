using Sanshop.Models;


namespace Sanshop.Services.SkladServices
{
    public class SkladService : ISkladService
    {

        private readonly DataContext _context;

        public SkladService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Sklad>> AddSklad(Sklad oneSklad)
        {
            _context.Sklad.Add(oneSklad);

            await _context.SaveChangesAsync();

            return await _context.Sklad.ToListAsync();
        }

        public async Task<List<Sklad>?> DeleteSklad(int id)
        {
            var oneSklad = await _context.Sklad.FindAsync(id);
            if (oneSklad is null)
                return null;

            _context.Sklad.Remove(oneSklad);

            await _context.SaveChangesAsync();


            return await _context.Sklad.ToListAsync();
        }

        public async Task<List<Sklad>> GetAllSklad()
        {
            var sklads = await _context.Sklad.ToListAsync();
            return sklads;
        }

        public async Task<Sklad?> GetSingleSklad(int id)
        {
            var oneSklad = await _context.Sklad.FindAsync(id);
            if (oneSklad is null)
                return null;
            return oneSklad;
        }

        public async Task<List<Sklad>?> UpdateSklad(int id, Sklad request)
        {
            var oneSklad = await _context.Sklad.FindAsync(id);
            if (oneSklad is null)
                return null;

            oneSklad.Id = request.Id;
            oneSklad.NumberSklad = request.NumberSklad;
            oneSklad.Adress = request.Adress;

            await _context.SaveChangesAsync();

            return await _context.Sklad.ToListAsync();
        }
    }
}
