
using ApiFilmesDois.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFilmesDois.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        :base(opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
}
