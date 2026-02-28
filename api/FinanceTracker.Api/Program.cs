using FinanceTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Register layers
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();