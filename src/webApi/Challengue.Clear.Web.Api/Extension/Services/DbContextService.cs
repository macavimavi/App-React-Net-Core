using Challenge.Clear.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Challengue.Clear.Web.Api.Extension.Services
{
    public static class DbContextService
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration) => 
            services.AddDbContext<MoviesDbContext>(options =>
                                                   options.UseSqlServer(configuration.GetConnectionString("ChallengueClearDatabase"),
                                                   options => options.MigrationsAssembly("Challenge.Clear.Infrastructure")));
    }
}
