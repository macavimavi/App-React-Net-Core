using Challenge.Clear.Application.Interfaces.Repositories;
using Challenge.Clear.Core.Domain.Mapper;
using Challenge.Clear.Domain;
using Challenge.Clear.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challengue.Clear.Web.Api.Extension.Services
{
      public static class InterfacesService
    {
        public static IServiceCollection AddInterfaz(this IServiceCollection services) =>
            services.AddScoped<IMovieServices, MovieServices>()
                    .AddScoped<IMovieRepositoryAsync,MovieRepositoryAsync>()
                    .AddScoped<IMovieMapper, MovieMapper>();
    }
}
