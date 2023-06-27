using loja_api.domain.seller;
using loja_api.infra.data;

namespace loja_api.endpoints.seller;

public class SellerPost
{

	public static string Template => "/sellers";

	public static string[] Methods => new string[] { HttpMethod.Post.ToString() };

	public static Delegate Handle => Action;

	public static IResult Action(SellerRequest sellerRequest, ApplicationDbContext context)
	{

		var seller = new Seller
		{

			Name = sellerRequest.Name,
			CreatedBy = sellerRequest.Name,
			EditedBy = sellerRequest.Name,

		};
		context.Sellers.Add(seller);
		context.SaveChanges();
		return Results.Created($"{Template}/{seller.Id}", seller.Id);
	}
}
