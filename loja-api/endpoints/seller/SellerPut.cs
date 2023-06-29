using infra.data.efcore;
using Microsoft.AspNetCore.Mvc;

namespace loja_api.endpoints.seller;

public class SellerPut
{

  public static string Template => "/sellers/{id}";

  public static string[] Methods => new string[] { HttpMethod.Put.ToString() };

  public static Delegate Handle => Action;

  public static IResult Action([FromRoute] Guid id, SellerRequest sellerRequest, ApplicationDbContext context)
  {

    var seller = context.Sellers.Where(c => c.Id == id).FirstOrDefault();
    if (seller == null)
      return Results.NotFound();

		seller.Name = sellerRequest.Name;
		seller.EditedBy = sellerRequest.EditedBy;
		seller.EditedOn = DateTime.Now;
		seller.IsActive = sellerRequest.IsActive;    
    
    context.SaveChanges();

    return Results.Ok();
  }

}
