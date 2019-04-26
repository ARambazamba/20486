using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Cors.Infrastructure;
using JSNLog;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace Vouchers
{
    public class Startup
    {
        private readonly IHostingEnvironment env;

        public Startup(IHostingEnvironment environment)
        {
            env = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Config
            var cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            var configuration = cfgBuilder.Build();
            services.Configure<VouchersConfig>(configuration);
            services.AddSingleton(typeof(IConfigurationRoot), configuration);
            var conStr = configuration["ConnectionStrings:DockerConnection"];

            //EF
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<VouchersDBContext>(options => options.UseSqlServer(conStr));
            services.AddScoped<IVouchersRepository, VouchersRepository>();

            //Simple Windows Auth
            services.AddAuthentication(HttpSysDefaults.AuthenticationScheme);

            //Firebase
            var fbrealm = configuration["Authentication:Firebase:Realm"];

            services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = "https://securetoken.google.com/" + fbrealm;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = "https://securetoken.google.com/" + fbrealm,
                    ValidateAudience = true,
                    ValidAudience = fbrealm,
                    ValidateLifetime = true
                };
            });

            //Identity 
            //
            //services.AddIdentity<VoucherUser, VoucherRole>()
            //    .AddEntityFrameworkStores<VouchersDBContext>()
            //    .AddDefaultTokenProviders();

            //Facebook Auth
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
            //    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //}).AddFacebook(options =>
            //{
            //    options.AppId = configuration["Authentication:Facebook:AppId"];
            //    options.AppSecret = configuration["Authentication:Facebook:AppSecret"];
            //}).AddCookie();

            //CORS
            //Required if you develop Angular on a seperate proj
            // For specific URL ie. your Angular CLI Frontend use: 
            // corsBuilder.WithOrigins("http://localhost:4200")           

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowAnyOrigin()
                        .AllowCredentials());
            });

            //Serialization Options
            services.AddMvc().AddJsonOptions(ser =>
            {
                ser.SerializerSettings.ContractResolver =
                    new DefaultContractResolver();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            VouchersDBContext dbcontext)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }else{
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }


            //Startup File for serving a *.html as default

            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(options);

            if (env.IsDevelopment())
            {
                app.UseStaticFiles(new StaticFileOptions
                {
                    OnPrepareResponse = context =>
                    {
                        context.Context.Response.Headers["Cache-Control"] = "no-cache, no-store";
                        context.Context.Response.Headers["Pragma"] = "no-cache";
                        context.Context.Response.Headers["Expires"] = "-1";
                    }
                });
            }
            else
            {
                app.UseStaticFiles();
            }

            //Cors
            app.UseCors("AllowAll");

            //Auth
            // app.UseAuthentication();

            app.UseHttpsRedirection();
            app.UseMvc();
        }

    }
}