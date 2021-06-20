using MediatR;
using System.Collections.Generic;

namespace PostLand.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<List<GetPostsListViewModel>>
    {

    }
}
