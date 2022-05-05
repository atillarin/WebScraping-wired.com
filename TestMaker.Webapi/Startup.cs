using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMaker.Bll.Abstract;
using TestMaker.Bll.Concrete;
using TestMaker.Dal.Abstract;
using TestMaker.Dal.Concrete.EntityFramework.Context;
using TestMaker.Dal.Concrete.EntityFramework.Repository;
using TestMaker.Entity.Concrete.Mapper;

namespace TestMaker.Webapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region ManagerSection
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<ITestManager, TestManager>();
            services.AddScoped<IQuestionManager, QuestionManager>();
            services.AddScoped<IExamManager, ExamManager>();
            


            #endregion

            #region RepositorySection
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            #endregion

            //services.AddControllers();
            //services.AddAutoMapper(typeof(Startup));
            //services.AddAutoMapper(typeof(MappingProfile));

            #region ApplicationContext
            //services.AddDbContext<NORTHWNDContext>();
            //services.AddScoped<DbContext, NORTHWNDContext>();
            //services.AddScoped<defaultContext, defaultContext>();

            services.AddDbContext<defaultContext>(opt =>
            {
                opt.UseSqlite(Configuration.GetConnectionString("SqliteServer"), sqlOpt =>
                {
                    sqlOpt.MigrationsAssembly("TestMaker.Dal");
                });
            });


            #endregion

            

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TestMaker.Webapi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestMaker.Webapi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
