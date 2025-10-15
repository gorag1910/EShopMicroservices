var builder = WebApplication.CreateBuilder(args);

//Add services to DI continer

var app = builder.Build();

// Configure the HTTP request pipeline

app.Run();
