using System.Data.Entity;

namespace CadastroClientesAutoComplete.Models
{
    public class ClientesContext : DbContext
    {
        public ClientesContext() : base("DbAutocomplete")
        {
            Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);
            Database.SetInitializer<ClientesContext>(new CreateDatabaseIfNotExists<ClientesContext>());
            Database.Initialize(false);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}