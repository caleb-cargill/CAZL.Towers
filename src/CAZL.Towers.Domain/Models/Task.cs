
namespace CAZL.Towers.Domain.Models;

public class Task : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public TaskStatus Status { get; set; }
    public List<User> AssignedTo { get; set; }

}
