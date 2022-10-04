using System.Text;
using CustomerLibrary.DataAccess;
using CustomerApi.StartUpConfig;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

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

app.MapHealthChecks("/health").AllowAnonymous();

app.Run();
