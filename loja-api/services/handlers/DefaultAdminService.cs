using loja_api.domain.customer;
using loja_api.domain.seller;
using loja_api.infra.data.customer;
using loja_api.infra.data.seller;

namespace loja_api.services.handlers;

public class DefaultAdminService : IAdminService
{
	readonly ICustomerRequest _customerRequest;
	readonly ISellerRequest _sellerRequest;
	public DefaultAdminService(ICustomerRequest customerRequest, ISellerRequest sellerRequest)
	{
		_customerRequest = customerRequest;
		_sellerRequest = sellerRequest;
	}
	public void AddCustomer(Customer customer)
	{
		_customerRequest.Add(customer);
	}
	public void DeleteCustomer(Customer customer)
	{
		_customerRequest.Remove(customer);
	}
	public void UpdateCustomer(Customer customer)
	{
		_customerRequest.Modify(customer);
	}
	public void AddSeller(Seller seller)
	{
		_sellerRequest.Add(seller);
	}
	public void DeleteSeller(Seller seller)
	{
		_sellerRequest.Remove(seller);
	}
	public void UpdateSeller(Seller seller)
	{
		_sellerRequest.Modify(seller);
	}
}