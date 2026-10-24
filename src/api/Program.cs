var builder = WebApplication.CreateBuilder(args);
// Keep the development server on this machine unless explicitly configured.
if (string.IsNullOrWhiteSpace(builder.Configuration["urls"]))
{
    builder.WebHost.UseUrls("http://localhost:5050");
}
var app = builder.Build();

app.MapGet("/api/health", () => Results.Ok(new
{
    service = "LitterLens.Api",
    status = "ok"
}));

app.Run();
