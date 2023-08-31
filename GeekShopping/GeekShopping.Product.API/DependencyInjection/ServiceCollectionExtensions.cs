using GeekShopping.Product.API.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Product.API.DependencyInjection
{
    public static class WebApplicationBuilderExtensions
    {
        public static WebApplicationBuilder AddMySqlDbContext(this WebApplicationBuilder builder)
        {
            var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
            builder.Services.AddDbContext<MySqlContext> (options => options.
                UseMySql(connection,
                        new MySqlServerVersion(
                            new Version(8,0,32)
                            )
                        )
                );
            return builder;
        }
    }
}
