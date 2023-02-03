using Patterns.Strategy;
using Patterns.Strategy.ConcreteCookingStrategies;
using Patterns.Strategy.ConcreteCookingStrategies.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services Strategy pattern EMS
builder.Services.AddScoped<ICooker, Cooker>();
builder.Services.AddScoped<ICookingStrategy, DeepFryCooker>();
builder.Services.AddScoped<ICookingStrategy, GrillCooker>();
builder.Services.AddScoped<ICookingStrategy, RoastCooker>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
