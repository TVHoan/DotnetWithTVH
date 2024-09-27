
using RoutingTVH.Router;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouterService();
var app = builder.Build();

app.UseRouter();

app.Run();