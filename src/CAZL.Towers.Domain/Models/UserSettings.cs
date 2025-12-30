namespace CAZL.Towers.Domain.Models;

public class UserSettings
{
    public string UserId { get; set; }
    public Theme Theme { get; set; }
    public string? AccentColorHex { get; set; }
}
