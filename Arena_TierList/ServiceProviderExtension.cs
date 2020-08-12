using Arena_TierList.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList
{
    public static class ServiceProviderExtension
    {

        public static void AddCardRepositoryServies(this IServiceCollection services)
        {
            services.AddScoped<ICardRepository, CardRepositoryServies>();
           
        }

    }
}
