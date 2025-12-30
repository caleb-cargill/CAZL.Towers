namespace CAZL.Towers.Domain.Models;

public class EntityBase : IEntity
{
    public string Id { get; set; }

    public string CreatedBy { get; set; }

    public string LastModifiedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime LastModifiedOn { get; set; }
}
