using infra.data.efcore;
using loja_api.domain.seller;
using loja_api.infra.data.seller;

namespace loja_api.infra.data.efcore;
public class SellerRequestWithEfCore : ISellerRequest
{
	ApplicationDbContext _context;
	public SellerRequestWithEfCore(ApplicationDbContext context)
  {
    _context = context;
  }
  public void Add(Seller seller)
	{
		_context.Sellers.Add(seller);
		_context.SaveChanges();
	}
	public void Modify(Seller seller)
	{
		_context.Sellers.Update(seller);
		_context.SaveChanges();
	}
	public void Remove(Seller seller)
	{
		_context.Sellers.Remove(seller);
		_context.SaveChanges();
	}
}

