using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.AutoMapper.Profiles;
using ProgrammersBlog.Mvc.Filters;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Mvc.Helpers.Concrete;
using ProgrammersBlog.Services.AutoMapper.Profiles;
using ProgrammersBlog.Services.Extensions;
using ProgrammersBlog.Shared.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProgrammersBlog.Mvc
{
    public class Startup
    {
        public IConfiguration Configuration { get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));
            services.Configure<WebsiteInfo>(Configuration.GetSection("WebsiteInfo"));
            services.Configure<SmtpSettings>(Configuration.GetSection("SmtpSettings"));
            services.ConfigureWritable<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));
            services.ConfigureWritable<WebsiteInfo>(Configuration.GetSection("WebsiteInfo"));
            services.ConfigureWritable<SmtpSettings>(Configuration.GetSection("SmtpSettings"));

            services.AddControllersWithViews(options => {

                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value=>"Bu alan bo? ge?ilmemelidir");
                options.Filters.Add<MvcExceptionFilter>();

            }).AddRazorRuntimeCompilation().AddJsonOptions(opt=> 
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                

            }).AddNToastNotifyToastr();
            services.AddSession();
            services.AddAutoMapper(typeof(CategoryProfile), typeof(ArticleProfile), typeof(UserProfile),typeof(ViewModelsProfile),typeof(CommentProfile),typeof(ContactProfile));
            services.LoadMyServices(connectionString:Configuration.GetConnectionString("LocalDb"));
            services.AddScoped<IImageHelper, ImageHelper>();
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login/");
                options.LogoutPath= new PathString("/Admin/Auth/Logout/");
                options.Cookie = new CookieBuilder
                {
                    Name = "ProgrammersBlog",
                    HttpOnly = true,
                    SameSite=SameSiteMode.Strict,
                    SecurePolicy=CookieSecurePolicy.Always //Always olmal? normalde

                };

                options.SlidingExpiration = true;
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
                options.AccessDeniedPath= new PathString("/Admin/Auth/AccessDenied");
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseSession();
            app.UseStaticFiles(); // wwwroot u kontrol eder
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseNToastNotify();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapDefaultControllerRoute();
            });
           
        }
    }
}
