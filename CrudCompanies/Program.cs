using CrudCompanies.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<CompaniesContext, CompaniesContext>(); 
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CompaniesContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), 
    assembly => assembly.MigrationsAssembly(typeof(CompaniesContext).Assembly.FullName));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
