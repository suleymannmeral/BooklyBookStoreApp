using BooklyBookStoreApp.API.Middlewares;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using BooklyBookStoreApp.Persistence.Context;
using BooklyBookStoreApp.Persistence.Repositorires;
using BooklyBookStoreApp.Persistence.Services;
using BooklyBookStoreApp.Presentation.ActionFilters;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IRepositoryManager,RepositoryManager>();
builder.Services.AddAutoMapper(typeof(BooklyBookStoreApp.Persistence.AssemblyReference).Assembly);
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IUserService, UserService>();

// Connection string
string connectionString = builder.Configuration.GetConnectionString("SqlServer");

// DbContext registration
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();
   

builder.Services.AddScoped<ValidationFilterAttribute>();

builder.Services.AddControllers()
    .AddApplicationPart(typeof(BooklyBookStoreApp.Presentation.AssemblyReference).Assembly)
    .AddFluentValidation(config =>
    {
        config.RegisterValidatorsFromAssembly(typeof(BooklyBookStoreApp.Application.AssemblyReference).Assembly);
    })
    .ConfigureApiBehaviorOptions(options =>
    {
        // Model validation hatalarını özel biçimde ele al
        options.InvalidModelStateResponseFactory = context =>
        {
            var errors = context.ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );

            var result = new
            {
                success = false,
                message = "Validation failed",
                errors = errors
            };

            return new BadRequestObjectResult(result);
        };
    });


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policyBuilder => policyBuilder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowAll");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.ConfigureExceptionHandler();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
