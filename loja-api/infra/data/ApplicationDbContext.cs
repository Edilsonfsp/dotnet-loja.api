using Microsoft.EntityFrameworkCore;
using loja_api.domain.customer;
using loja_api.domain.seller;

namespace loja_api.infra.data;

public class ApplicationDbContext : DbContext
{

	public DbSet<Customer> Customers { get; set; }  //Aqui sao as tabelas
	public DbSet<Seller> Sellers { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Customer>()
			.Property(c => c.Name).IsRequired();

		builder.Entity<Seller>()
			.Property(s => s.Name).IsRequired();
	}

	protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
	{
		configuration.Properties<string>().HaveMaxLength(100);
	}

}
