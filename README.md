# Endpoints.FluentValidation
Super Simplify validation Minimal APIs in ASP.NET Core 7 or later with Short-circuit endpoint executions.

## It's an extension for `FluentValidation` Package


## First create your Dto and validator
```csharp
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

```

## Second configure validation service 
```csharp
builder.Services.AddScoped<IValidator<CreateProductDto>,CreateProductValidator>();
```
****

## Finally validate your endpoints
```csharp
app.MapPost("/products/create", async (CreateProductDto product) =>
{
    // code command execution
}).Validator<CreateProductDto>();

```
