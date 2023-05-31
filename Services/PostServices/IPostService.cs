using Sanshop.Models;

namespace Sanshop.Services.PostServices
{
    public interface IPostService
    {
        Task<List<Post>> GetAllPost();

        Task<Post?> GetSinglePost(int id);

        Task<List<Post>> AddPost(Post onePost);

        Task<List<Post>?> UpdatePost(int id, Post request);

        Task<List<Post>?> DeletePost(int id);
    }
}
