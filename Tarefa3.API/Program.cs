using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Application.Services;
using Tarefa3.Data.Rest.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<RickAndMortyRepository>();
builder.Services.AddScoped<ViaCepRepository>();

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IViaCepService, ViaCepService>();
builder.Services.AddScoped<IRickAndMortyService, RickAndMortyService>();

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