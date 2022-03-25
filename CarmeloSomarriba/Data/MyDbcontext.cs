using CarmeloSomarriba.Models;
using Microsoft.EntityFrameworkCore;
using WEB_Core_Conv2.Models;

namespace CarmeloSomarriba.Data
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {
        }

        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


    }
}

