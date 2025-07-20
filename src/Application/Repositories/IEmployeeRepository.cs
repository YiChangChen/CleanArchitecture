using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Application.Repositories
{
    public interface IEmployeeRepository
    {
         Task AddAsync(Employee entity);
    }
}