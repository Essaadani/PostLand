using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts.Persistence
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory);
        Task<Post> GetPostByIdAsync(Guid id, bool includeCategory);
    }
}
