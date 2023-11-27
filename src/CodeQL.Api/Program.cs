using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);
builder.Services.AddTransient<SQLInjection>();

var app = builder.Build();

app.MapGet("/example/{id}", async (SQLInjection injection, string id) =>
{
    await injection.Vulnerability(id);
    return Results.Ok(id);
});

app.Run();
