namespace loja_api.endpoints.seller;

internal class SellerResponse
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public DateTime CreateOn { get; set; }
	public string EditedBy { get; set; }
	public bool IsActive { get; set; }
}