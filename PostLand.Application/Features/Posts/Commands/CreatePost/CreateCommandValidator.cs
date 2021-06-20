using FluentValidation;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreateCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            
            RuleFor(p => p.Content)
                .NotEmpty()
                .NotNull();
        }
    }
}
