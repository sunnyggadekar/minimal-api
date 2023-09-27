var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("api/customers", () => "cutomers");
app.MapGet("api/customers/{Id}", () => "one customer");
app.MapPost("api/customers", () => "customers created");
app.MapPut("api/customers/{Id}", () => "customer updated");
app.MapDelete("api/customers/{Id}", () => "customer deleted");

app.Run();
