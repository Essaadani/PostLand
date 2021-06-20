using AutoMapper;
using PostLand.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, GetPostDetailViewModel>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostDetailQueryHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<GetPostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
        {
            var Post = await _postRepository.GetPostByIdAsync(request.PostId, true);

            return _mapper.Map<GetPostDetailViewModel>(Post);
        }
    }
}
