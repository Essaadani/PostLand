using MediatR;
using System;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

    }
}
