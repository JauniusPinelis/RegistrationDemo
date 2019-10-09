using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Registration.Infrastructure.Db;
using Registration.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registration.Infrastructure.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRegistrationRepository, RegistrationRepository>();
        }

        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<RegistrationContext>(options =>
               options.UseSqlServer(connectionString));
        }

        public static void ConfigureLoggers(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
