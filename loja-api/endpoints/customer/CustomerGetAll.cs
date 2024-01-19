using infra.data.efcore;

namespace loja_api.endpoints.customer;

public class CustomerGetAll
{

  public static string Template => "/customers";

  public static string[] Methods => new string[] { HttpMethod.Get.ToString() };

  public static Delegate Handle => Action;

  public static IResult Action(ApplicationDbContext context)
  {

    var customers = context.Customers.ToList();
    var response = customers.Select(c => new CustomerResponse { 
      Id  = c.Id,
      Name = c.Name,
      CreateOn = c.CreatedOn,
      EditedBy = c.EditedBy,
      IsActive = c.IsActive
    });
    
    return Results.Ok(response);
  }

}
