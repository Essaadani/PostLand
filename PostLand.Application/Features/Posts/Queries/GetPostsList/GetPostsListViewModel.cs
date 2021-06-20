using System;

namespace PostLand.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public CategoryDto Category { get; set; }
    }
}
