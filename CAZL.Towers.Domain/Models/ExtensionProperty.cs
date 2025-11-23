
namespace CAZL.Towers.Domain.Models;

public class ExtensionProperty : EntityBase
{
    public string Name { get; set; }
    public ExtensionPropertyType ExtensionPropertyType { get; set; }
}