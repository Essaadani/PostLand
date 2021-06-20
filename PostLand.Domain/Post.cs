using System;

namespace PostLand.Domain
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }

}
