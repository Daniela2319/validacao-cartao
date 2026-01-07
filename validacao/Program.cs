using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using validacao.SwaggerExamples.Filters;

var builder = WebApplication.CreateBuilder(args);
var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "validacao.xml"));
    c.SwaggerDoc("v1", new() 
    { 
        Title = "API de Validação de Cartão de Crédito",
        Version = "v1",
        Description = "API responsável por validar dados básicos de cartão de crédito",
        Contact = new OpenApiContact
        {
            Name = "DVFWeb - Daniela",
            Url = new Uri("https://www.linkedin.com/in/danielavelteredu/")
        }
    });

    c.OperationFilter<CreditCardExampleOperationFilter>();
});

builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowReact",
      policy => policy
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowReact");

app.MapControllers();

app.Run();
