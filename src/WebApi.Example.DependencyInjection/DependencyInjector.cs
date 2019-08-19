using Microsoft.Extensions.DependencyInjection;
using System;
using WebApi.Example.Interface.Repository;
using WebApi.Example.Repository;

namespace WebApi.Example.DependencyInjection
{
    public static class DependencyInjector
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, PersonRepository>();
        }
    }
}
