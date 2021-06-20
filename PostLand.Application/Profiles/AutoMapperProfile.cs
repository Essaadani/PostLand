using AutoMapper;
using PostLand.Application.Features.Posts.Commands.CreatePost;
using PostLand.Application.Features.Posts.Commands.DeletePost;
using PostLand.Application.Features.Posts.Commands.UpdatePost;
using PostLand.Application.Features.Posts.Queries.GetPostDetail;
using PostLand.Application.Features.Posts.Queries.GetPostsList;
using PostLand.Domain;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
            CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }
}
