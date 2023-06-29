using infra.data.efcore;
using loja_api.domain.customer;
using loja_api.endpoints.customer;
using loja_api.infra.data.customer;

namespace loja_api.infra.data.efcore;
public class CustomerRequestWithEfCore : ICustomerRequest
{
	ApplicationDbContext _context;
	public CustomerRequestWithEfCore(ApplicationDbContext context)
  {
    _context = context;
  }
  public void Add(Customer customer)
	{
		_context.Customers.Add(customer);
		_context.SaveChanges();
	}
	public void Modify(Customer customer)
	{
		_context.Customers.Update(customer);
		_context.SaveChanges();
	}
	public void Remove(Customer customer)
	{
		_context.Customers.Remove(customer);
		_context.SaveChanges();
	}
}

