using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Autofac, Ninject,CastleWindsor,SwtructureMap,LightInject, DryInject --> IoC Container
            //AOP 
            services.AddControllers();
            services.AddSingleton<IProductService, ProductManager>();
            //AddSingleton = Arka planda bir referans oluştur. Ancak içerisinde veri tutulmuyorsa
            services.AddSingleton<IProductDal, EfProductDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
    }
}
