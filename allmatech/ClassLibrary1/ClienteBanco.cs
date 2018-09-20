namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClienteBanco : DbContext
    {
        public ClienteBanco()
            : base("name=ClienteBanco")
        {
        }

        public virtual DbSet<tbCliente> tbCliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbCliente>()
                .Property(e => e.nome)
                .IsFixedLength();

            modelBuilder.Entity<tbCliente>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<tbCliente>()
                .Property(e => e.cpf)
                .IsFixedLength();

            modelBuilder.Entity<tbCliente>()
                .Property(e => e.carromarca)
                .IsFixedLength();

            modelBuilder.Entity<tbCliente>()
                .Property(e => e.carromodelo)
                .IsFixedLength();
        }
    }
}
