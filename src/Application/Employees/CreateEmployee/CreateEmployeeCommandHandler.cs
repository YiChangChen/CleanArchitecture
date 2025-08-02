using Application.Repositories;
using Domain;
using MediatR;

namespace Application.Employees.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee { Name = request.Name, Email = request.Email };
            await _employeeRepository.AddAsync(employee);
            return employee.Id;
        }
    }
}