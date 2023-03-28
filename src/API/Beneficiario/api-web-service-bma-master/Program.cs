using api_web_service_bma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.SwaggerDoc("v1", new OpenApiInfo
    {

        Title = "Banco de Alimentos - OpenAPI 3.0",
        Version = "v1",
        Description = "Esse é um Sistema de cadastro baseado nas especificações OpenAPI 3.0. O Banco de Alimentos é um sistema com o objetivo de facilitar e agilizar o processo de cadastro de entrega de cestas básicas para famílias que encontram-se em situação de vulnerabilidade social. Projeto criado e desenvolvido pelas alunas: Amanda Paloma e Elaine Souza para o 4º período do curso de Sistemas para Internet, ministrado na Puc Minas EAD",


    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Banco de Alimentos V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
