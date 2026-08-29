using Microsoft.EntityFrameworkCore;
using TecnoGasHogar.Models;

namespace TecnoGasHogar.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<SolicitudServicio> Solicitudes { get; set; } = null!;
}