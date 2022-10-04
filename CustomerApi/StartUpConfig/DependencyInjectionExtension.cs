using System.Text;
using CustomerLibrary.DataAccess;

namespace CustomerApi.StartUpConfig;

public static class DependencyInjectionExtension
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
        builder.Services.AddSingleton<ICustomerData, CustomerData>();

        builder.Services.AddHealthChecks()
                         .AddSqlServer(builder.Configuration.GetConnectionString("Default"));
    }
}
