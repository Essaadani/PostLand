using MediatR;
using System;

namespace PostLand.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest
    {
        public Guid PostId { get; set; }
    }

}
