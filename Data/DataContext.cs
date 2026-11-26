using Microsoft.EntityFrameworkCore;
using CrudProjeto.models;

namespace CrudProjeto.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ClassificadorProjeto> ClassificadoresProjeto { get; set; }
    }
}

