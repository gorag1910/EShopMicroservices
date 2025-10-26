var builder = WebApplication.CreateBuilder(args);

//Register services into DI COntainer
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

//Configure HTTP request pipeline
app.MapReverseProxy();

app.Run();
