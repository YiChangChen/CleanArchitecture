using Domain;

namespace Application.Repositories
{
    public interface IEmployeeRepository
    {
         Task AddAsync(Employee entity);
    }
}