using loja_api.domain.customer;
using loja_api.services;

namespace loja_api.endpoints.customer;

public class CustomerPost
{
	public static string Template => "/customers";
  public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
  public static Delegate Handle => Action;
  public static IResult Action(CustomerRequest customerRequest, IAdminService service)
  {
    var customer = new Customer
    {
      Name = customerRequest.Name,
      CreatedBy = customerRequest.Name,
      EditedBy = customerRequest.Name
    };
		service.AddCustomer(customer);
    return Results.Created($"{Template}/{customer.Id}", customer.Id);
  }
}
