using Sanshop.Models;

namespace Sanshop.Services.ClientServices
{
    public interface IClientService
    {
        Task<List<Client>> GetAllClient();

        Task<Client?> GetSingleClient(int id);

        Task<List<Client>> AddClient(Client oneClient);

        Task<List<Client>?> UpdateClient(int id, Client request);

        Task<List<Client>?> DeleteClient(int id);
    }
}
