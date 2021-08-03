using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challengue.Clear.Web.Api.Extension.Application
{
    public static class SwaggerGenApp
    {
        public static IServiceCollection AddSwaggerGen(this IServiceCollection services)
        {
            return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Challegue Clear",
                    Description = "Challegue Clear",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Michael V.",
                        Email = string.Empty,
                        Url = null,
                    },
                    License = new OpenApiLicense
                    {
                        Name = string.Empty,
                        Url = null,
                    }
                });
            });
        }

    }
}
