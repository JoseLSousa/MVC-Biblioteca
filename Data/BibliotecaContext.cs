using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCBiblioteca.Models;

namespace MVCBiblioteca.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext (DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<MVCBiblioteca.Models.Livro> Livro { get; set; } = default!;
        public DbSet<MVCBiblioteca.Models.Emprestimo> Emprestimo { get; set; }
        public DbSet<MVCBiblioteca.Models.Usuario> Usuario { get; set; }
    }
}
