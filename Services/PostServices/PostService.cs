using Sanshop.Models;

namespace Sanshop.Services.PostServices
{
    public class PostService : IPostService
    {

        private readonly DataContext _context;

        public PostService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Post>> AddPost(Post onePost)
        {
            _context.Post.Add(onePost);

            await _context.SaveChangesAsync();

            return await _context.Post.ToListAsync();
        }

        public async Task<List<Post>?> DeletePost(int id)
        {
            var onePost = await _context.Post.FindAsync(id);
            if (onePost is null)
                return null;

            _context.Post.Remove(onePost);

            await _context.SaveChangesAsync();


            return await _context.Post.ToListAsync();
        }

        public async Task<List<Post>> GetAllPost()
        {
            var posts = await _context.Post.ToListAsync();
            return posts;
        }

        public async Task<Post?> GetSinglePost(int id)
        {
            var onePost = await _context.Post.FindAsync(id);
            if (onePost is null)
                return null;
            return onePost;
        }

        public async Task<List<Post>?> UpdatePost(int id, Post request)
        {
            var onePost = await _context.Post.FindAsync(id);
            if (onePost is null)
                return null;

            onePost.Id = request.Id;
            onePost.Identificator = request.Identificator;
            onePost.Poost = request.Poost;
            onePost.TittlePost = request.TittlePost;

            await _context.SaveChangesAsync();

            return await _context.Post.ToListAsync();
        }
    }
}
