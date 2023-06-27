namespace loja_api.endpoints.seller;

public class SellerRequest
{
	public string Name { get; set; }
	public string CreateBy { get; set; }
	public string EditedBy { get; set; }
	public bool IsActive { get; set; }

}