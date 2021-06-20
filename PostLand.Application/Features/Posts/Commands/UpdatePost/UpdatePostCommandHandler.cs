using AutoMapper;
using PostLand.Application.Contracts.Persistence;
using PostLand.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;
        public UpdatePostCommandHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(request);

            await _postRepository.UpdateAsync(post);

            return Unit.Value;
        }
    }
}
