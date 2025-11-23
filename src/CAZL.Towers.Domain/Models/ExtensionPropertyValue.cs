namespace CAZL.Towers.Domain.Models;

public class ExtensionPropertyValue : EntityBase
{
    public ExtensionProperty ExtensionProperty { get; set; }
    public string Value { get; set; }
}