using Application.Employees.CreateEmployee;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
[assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Register MediatR
builder.Services.AddMediatR(configuration =>
    configuration.RegisterServicesFromAssemblies(
        typeof(Program).Assembly, // 掃描 API 組件
        typeof(CreateEmployeeCommand).Assembly // 掃描 Application 組件
    )
);

builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();