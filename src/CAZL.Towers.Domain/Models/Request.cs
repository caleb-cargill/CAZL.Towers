
namespace CAZL.Towers.Domain.Models;

public class Request : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public RequestStatus Status { get; set; }
    public User AssignedTo { get; set; }
}
