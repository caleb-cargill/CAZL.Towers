
namespace CAZL.Towers.Domain.Models;

public class Request : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public RequestStatus Status { get; set; }
    public List<User> AssignedTo { get; set; }

}
