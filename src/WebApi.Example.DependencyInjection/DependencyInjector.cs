using Microsoft.Extensions.DependencyInjection;
using System;
using WebApi.Example.Business;
using WebApi.Example.Business.Interface;
using WebApi.Example.Repository;
using WebApi.Example.Repository.Interface;

namespace WebApi.Example.DependencyInjection
{
    public static class DependencyInjector
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IPersonBusiness, PersonBusiness>();

            services.AddSingleton<IPersonRepository, PersonRepository>();
        }
    }
}
