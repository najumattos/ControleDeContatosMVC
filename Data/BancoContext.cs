using Microsoft.EntityFrameworkCore;

namespace CadastroDeContatosMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> opcoes) : base(opcoes)
        {
        }

        public DbSet<Models.ContatoModel> Contatos { get; set; }
    }
}
