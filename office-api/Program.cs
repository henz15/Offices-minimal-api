var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var offices = new Dictionary<int, string>()
    {
        { 1, "Lilongwe" },
        { 2, "Blantyre" }
    };
    return offices;
});

app.Run();