using WebApp;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<CreateProductDto>,CreateProductValidator>();
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapPost("/products/create", async (CreateProductDto product) =>
{
    // code command execution
}).Validator<CreateProductDto>();


app.Run();

 