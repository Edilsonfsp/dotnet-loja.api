using loja_api.domain.customer;
using loja_api.domain.seller;

namespace loja_api.services;
public interface IAdminService
{
	void AddCustomer(Customer customer);
	void UpdateCustomer(Customer customer);
	void DeleteCustomer(Customer customer);
	void AddSeller(Seller seller);
	void UpdateSeller(Seller seller);
	void DeleteSeller(Seller seller);
}
