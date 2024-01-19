using infra.data.efcore;

namespace loja_api.endpoints.seller;

public class SellerGetAll
{

	public static string Template => "/sellers";

	public static string[] Methods => new string[] { HttpMethod.Get.ToString() };

	public static Delegate Handle => Action;

	public static IResult Action(ApplicationDbContext context)
	{

		var sellers = context.Sellers.ToList();
		var response = sellers.Select(s => new SellerResponse
		{

			Id = s.Id,
			Name = s.Name,
			CreateOn = s.CreatedOn,
			EditedBy = s.EditedBy,
			IsActive = s.IsActive

		});

		return Results.Ok(response);
	}
}