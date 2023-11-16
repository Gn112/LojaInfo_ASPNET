using LojaInfo_ASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaInfo_ASPNET.Data
{
    public class ContextoDB : DbContext
    {
        public ContextoDB(DbContextOptions options): base(options) { }
        public DbSet<ModelClientes> clientes { get; set; }
    }
}
