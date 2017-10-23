using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace fibonacci2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseStaticFiles();

            app.Run(async (context) =>
            {
                var path = context.Request.Path.Value;
                var dictionaryPath = new Dictionary<string, Func<string>>();
                dictionaryPath["/index=1"] = () => { return "1"; };
                dictionaryPath["/index=2"] = () => { return "1"; };
                dictionaryPath["/index=3"] = () => { return "2"; };
                dictionaryPath["/index=4"] = () => { return "3"; };
                dictionaryPath["/index=5"] = () => { return "5"; };
                dictionaryPath["/index=6"] = () => { return "8"; };
                dictionaryPath["/index=7"] = () => { return "13"; };
                dictionaryPath["/index=8"] = () => { return "21"; };
                dictionaryPath["/index=9"] = () => { return "34"; };
                dictionaryPath["/index=10"] = () => { return "55"; };
                dictionaryPath["/index=11"] = () => { return "89"; };
                dictionaryPath["/index=12"] = () => { return "114"; };
                dictionaryPath["/index=13"] = () => { return "233"; };
                dictionaryPath["/index=14"] = () => { return "377"; };
                dictionaryPath["/index=15"] = () => { return "610"; };
                dictionaryPath["/index=16"] = () => { return "987"; };
                dictionaryPath["/index=17"] = () => { return "1597"; };
                dictionaryPath["/index=18"] = () => { return "2584"; };
                dictionaryPath["/index=19"] = () => { return "4181"; };
                dictionaryPath["/index=20"] = () => { return "6765"; };
                dictionaryPath["/index=21"] = () => { return "10946"; };
                dictionaryPath["/index=22"] = () => { return "17711"; };
                dictionaryPath["/index=23"] = () => { return "28657"; };
                dictionaryPath["/index=24"] = () => { return "46368"; };
                dictionaryPath["/index=25"] = () => { return "75025"; };
                dictionaryPath["/index=26"] = () => { return "121393"; };
                dictionaryPath["/index=27"] = () => { return "196418"; };
                dictionaryPath["/index=28"] = () => { return "317811"; };
                dictionaryPath["/index=29"] = () => { return "514229"; };
                dictionaryPath["/index=30"] = () => { return "832040"; };
                dictionaryPath["/index=31"] = () => { return "1346269"; };
                dictionaryPath["/index=32"] = () => { return "2178309"; };
                dictionaryPath["/index=33"] = () => { return "3524578"; };
                dictionaryPath["/index=34"] = () => { return "5702887"; };
                dictionaryPath["/index=35"] = () => { return "9227465"; };
                dictionaryPath["/index=36"] = () => { return "14930352"; };
                dictionaryPath["/index=37"] = () => { return "24157817"; };
                dictionaryPath["/index=38"] = () => { return "39088169"; };
                dictionaryPath["/index=39"] = () => { return "63245986"; };
                dictionaryPath["/index=40"] = () => { return "102334155"; };

                if (dictionaryPath.ContainsKey(path))
                {
                    await context.Response.WriteAsync(dictionaryPath[path]());
                }
                else
                {
                    await context.Response.WriteAsync("Error");
                }
            });
        }
    }
}