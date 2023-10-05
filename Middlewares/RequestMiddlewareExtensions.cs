using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_.core_dosya_yapımı_incelemesi.Middlewares
{
    public static class RequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestTime(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimeMidleware>();
        }
    }
}
