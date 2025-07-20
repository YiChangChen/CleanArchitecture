
using Application.Repositories;
using AutoMapper;
using Domain;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly EmployeeDbContext _context;
    private readonly IMapper _mapper;

    public EmployeeRepository(EmployeeDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task AddAsync(Employee employee)
    {
        var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
        // await _context.Employees.AddAsync(employeeEntity);
        // await _context.SaveChangesAsync();
    }
}