using Sanshop.Models;

namespace Sanshop.Services.ClientServices
{
    public class ClientService : IClientService
    {

        private readonly DataContext _context;

        public ClientService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> AddClient(Client oneClient)
        {
            _context.Client.Add(oneClient);

            await _context.SaveChangesAsync();

            return await _context.Client.ToListAsync();
        }

        public async Task<List<Client>?> DeleteClient(int id)
        {
            var oneClient = await _context.Client.FindAsync(id);
            if (oneClient is null)
                return null;

            _context.Client.Remove(oneClient);

            await _context.SaveChangesAsync();


            return await _context.Client.ToListAsync();
        }

        public async Task<List<Client>> GetAllClient()
        {
            var clients = await _context.Client.ToListAsync();
            return clients;
        }

        public async Task<Client?> GetSingleClient(int id)
        {
            var oneClient = await _context.Client.FindAsync(id);
            if (oneClient is null)
                return null;
            return oneClient;
        }

        public async Task<List<Client>?> UpdateClient(int id, Client request)
        {
            var oneClient = await _context.Client.FindAsync(id);
            if (oneClient is null)
                return null;

            oneClient.ClientId = request.ClientId;
            oneClient.Email = request.Email;
            oneClient.Phonenumber = request.Phonenumber;
            oneClient.Adress = request.Adress;

            await _context.SaveChangesAsync();

            return await _context.Client.ToListAsync();
        }
    }
}
