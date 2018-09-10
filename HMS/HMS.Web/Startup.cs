using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HMS.EntityFramework;
using Microsoft.EntityFrameworkCore;
using HMS.AutoMapper.SystemModule;
using Autofac;
using HMS.Common.Ioc;
using System.Reflection;
using Autofac.Extensions.DependencyInjection;

namespace HMS.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //程序启动时注册实体对应Dto的映射关系
            SystemProfile.Initialize();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            var sqlConnection = Configuration.GetConnectionString("SqlServerConnection");
            services.AddDbContext<HMSDbContext>(options => options.UseSqlServer(sqlConnection));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //session保存到内存
            services.AddDistributedMemoryCache();
            //session服务
            services.AddSession();
            //AutoFac依赖注入
            ContainerBuilder builder = new ContainerBuilder();
            Type baseType = typeof(IDependency);

            // 获取所有相关类库的程序集
            //Assembly[] assemblies = Assembly.Load();


            builder.RegisterAssemblyTypes(Assembly.Load("HMS.EntityFramework"))
                .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
                .AsImplementedInterfaces().InstancePerLifetimeScope();//InstancePerLifetimeScope 保证对象生命周期基于请求
            builder.RegisterAssemblyTypes(Assembly.Load("HMS.Application"))
               .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
               .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(Assembly.Load("HMS.Domin"))
               .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
               .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.Populate(services);
            IContainer container = builder.Build();
            
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            //session
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=System}/{action=Index}/{id?}"
                  );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
