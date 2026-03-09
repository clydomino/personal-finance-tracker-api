using FinanceTracker.Application.Users.CreateUser;
using FinanceTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Register layers
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly((typeof(CreateUserCommand)).Assembly));

var app = builder.Build();

app.MapControllers();

app.Run();