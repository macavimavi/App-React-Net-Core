using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challengue.Clear.Web.Api.Extension.Services
{
    public static class SwaggerGenServices
    {
        public static IApplicationBuilder AddSwaggerGen(this IApplicationBuilder app)
        {
            return app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            }).UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Challengue Clear");
            });
        }

    }
}
