using AutoMapper;
using YourProjectName.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<InstructorService>();

var app = builder.Build();

app.Run();
