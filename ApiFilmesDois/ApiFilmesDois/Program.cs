using ApiFilmesDois.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("FilmeConnection");

/*builder.Services.AddDbContext<FilmeContext>(opts =>
opts.UseMySql(builder.Configuration.GetConnectionString("FilmeConnection"), ServerVersion.AutoDetect(connectionString)));*/

builder.Services.AddDbContext<FilmeContext>(opts => opts.UseSqlServer("Data Source=IRON84\\SQLEXPRESS; Initial Catalog=filmes; User Id=root; Password=KellyR28@"));

// Add services to the container.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddControllers();
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
