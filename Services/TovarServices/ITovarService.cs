using Sanshop.Models;

namespace Sanshop.Services.TovarServices
{
    public interface ITovarService
    {
        Task<List<Tovar>> GetAllTovar();

        Task<Tovar?> GetSingleTovar(int id);

        Task<List<Tovar>> AddTovar(Tovar oneTovar);

        Task<List<Tovar>?> UpdateTovar(int id, Tovar request);

        Task<List<Tovar>?> DeleteTovar(int id);
    }
}
