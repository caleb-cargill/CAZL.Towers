namespace CAZL.Towers.Domain.Interfaces;

public interface IRequestService
{
    Task<IEnumerable<Request>> GetAll();
    Task<Request> Get();
    Task<Request> Add(Request request);
    Task<Request> Update(Request request);
    Task<bool> Delete(Request request);
}
