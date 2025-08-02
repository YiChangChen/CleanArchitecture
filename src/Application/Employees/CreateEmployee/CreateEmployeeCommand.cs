using MediatR;

namespace Application.Employees.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}