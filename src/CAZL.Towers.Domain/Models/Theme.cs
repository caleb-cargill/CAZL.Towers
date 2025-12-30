namespace CAZL.Towers.Domain.Models;

public class Theme : EntityBase 
{
    public string Name { get; set; }
    public string BackgroundPrimaryColor { get; set; }
    public string BackgroundSecondaryColor { get; set; }
    public string BackgroundAccentColor { get; set; }
    public string ForegroundPrimaryColor { get; set; }
    public string ForegroundSecondaryColor { get; set; }
    public string ForegroundAccentColor { get; set; }
}