using AutoMapper;
using MediatR;
using PostLand.Application.Contracts.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostsListViewModel>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<List<GetPostsListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var allPosts = await _postRepository.GetAllPostsAsync(true);
            return _mapper.Map<List<GetPostsListViewModel>>(allPosts);
        }
    }
}
