using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_.core_dosya_yapımı_incelemesi.Middlewares
{
    public class RequestTimeMidleware
    {
        private readonly RequestDelegate _next;

        public RequestTimeMidleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            File.AppendAllText("time.txt", DateTime.Now.TimeOfDay.ToString() + Environment.NewLine);
            await _next(context);
        }
    }
}
