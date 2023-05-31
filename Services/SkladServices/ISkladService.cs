using Sanshop.Models;

namespace Sanshop.Services.SkladServices
{
    public interface ISkladService
    {
        Task<List<Sklad>> GetAllSklad();

        Task<Sklad?> GetSingleSklad(int id);

        Task<List<Sklad>> AddSklad(Sklad oneSklad);

        Task<List<Sklad>?> UpdateSklad(int id, Sklad request);

        Task<List<Sklad>?> DeleteSklad(int id);
    }
}
