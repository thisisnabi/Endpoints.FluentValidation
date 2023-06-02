using FluentValidation;

namespace WebApp;

public sealed class CreateProductDto
{
    public string Title { get; set; }
}

public class CreateProductValidator : AbstractValidator<CreateProductDto>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty();
    }
}
