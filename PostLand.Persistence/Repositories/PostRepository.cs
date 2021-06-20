using PostLand.Application.Contracts.Persistence;
using PostLand.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostLand.Persistence
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext postDbContext): base(postDbContext)
        {

        }
        public async Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory)
        {
            List<Post> allPosts = new List<Post>();
            allPosts = includeCategory ? await _dbContext.Posts.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            return allPosts;
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool includeCategory)
        {
            Post Post = new Post();
            Post = includeCategory ? await _dbContext.Posts.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
            return Post;
        }
    }

}
