using AcademySistem.Aplicattion.DependecyInject;
using AcademySistem.Infra.Context;
using AcademySistem.Infra.DependecyInject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AcademySistemContext>(
                opt => opt.UseSqlServer("Server=localhost;Database=AcademySistem;Trusted_Connection=true;MultipleActiveResultSets=true;trustservercertificate=true"));
builder.Services.AddControllers();
builder.Services.AddInfrastruture()
                   .AddAplication();
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
