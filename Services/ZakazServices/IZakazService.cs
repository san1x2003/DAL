using Sanshop.Models;

namespace Sanshop.Services.ZakazServices
{
    public interface IZakazService
    {
        Task<List<Zakaz>> GetAllZakaz();

        Task<Zakaz?> GetSingleZakaz(int id);

        Task<List<Zakaz>> AddZakaz(Zakaz oneZakaz);

        Task<List<Zakaz>?> UpdateZakaz(int id, Zakaz request);

        Task<List<Zakaz>?> DeleteZakaz(int id);
    }
}
