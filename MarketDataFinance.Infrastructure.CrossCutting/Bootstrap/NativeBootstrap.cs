
using MarketDataFinance.Adapter;
using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using MarketDataFinance.Domain.Contracts.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace MarketDataFinance.Infrastructure.CrossCutting.Bootstrap
{
    public class NativeBootstrap
    {
        public static void serviceLocation(IServiceCollection services)
        {
            services.AddScoped<IDataAppServices, DataAppServices>();
            services.AddScoped<ISummaryAppService, SummaryAppService>();
            services.AddScoped<IAdapterData, AdapterData>();

        }
    }
}
