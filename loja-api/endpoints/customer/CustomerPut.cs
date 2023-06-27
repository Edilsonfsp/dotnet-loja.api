using loja_api.domain.customer;
using loja_api.infra.data;
using Microsoft.AspNetCore.Mvc;

namespace loja_api.endpoints.customer;

public class CustomerPut
{

  public static string Template => "/customers/{id}";

  public static string[] Methods => new string[] { HttpMethod.Put.ToString() };

  public static Delegate Handle => Action;

  public static IResult Action([FromRoute] Guid id, CustomerRequest customerRequest, ApplicationDbContext context)
  {

    var customer = context.Customers.Where(c => c.Id == id).FirstOrDefault();
    if (customer == null)
      return Results.NotFound();

    customer.Name = customerRequest.Name;
    customer.EditedBy = customerRequest.EditedBy;
    customer.EditedOn = DateTime.Now;
    customer.IsActive = customerRequest.IsActive;    
    
    context.SaveChanges();
    return Results.Ok();
  }

}
