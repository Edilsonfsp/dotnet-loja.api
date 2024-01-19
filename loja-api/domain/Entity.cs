namespace loja_api.domain;

public class Entity
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public string CreatedBy { get; set; }
  public DateTime CreatedOn { get; set; } = DateTime.Now;
  public string EditedBy { get; set; }
  public DateTime EditedOn { get; set; } = DateTime.Now;
  public bool IsActive { get; set; } = true;
  public bool IsDeleted { get; set; } = false;

  public Entity()
  {
    Id = Guid.NewGuid();
  }

}