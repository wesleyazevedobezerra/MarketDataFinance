
using MarketDataFinance.Adapter;
using MarketDataFinance.Adapter.Helpers;
using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using MarketDataFinance.Domain.Contracts.Adapters;
using MarketDataFinance.Domain.Contracts.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace MarketDataFinance.Infrastructure.CrossCutting.Bootstrap
{
    public static class NativeBootstrap
    {
        public static void serviceLocation(IServiceCollection services)
        {
            services.AddScoped<IDataAppServices, DataAppServices>();
            services.AddScoped<ISummaryAppService, SummaryAppService>();
            services.AddScoped<IChartAppService, ChartAppService>();
            services.AddScoped<ISearchNewsAppService, SearchNewsAppService>();
            services.AddScoped<IScreenshotAppService, ScreenshotAppService>();
            services.AddScoped<IAdapterData, AdapterData>();
            services.AddScoped<INewsAppService, NewsAppService>();
            services.AddScoped<IFinanceChartAppService, FinanceChartAppService>();
            services.AddScoped<IHtmlToBase64Helper, HtmlToBase64Helper>();
        }
    }
}
