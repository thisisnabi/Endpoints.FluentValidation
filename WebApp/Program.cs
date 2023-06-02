using WebApp;
using Endpoints.FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapPost("/products/create", async (CreateProductDto product) =>
{
    // code command execution
}).Validator<CreateProductDto>();


app.Run();

 