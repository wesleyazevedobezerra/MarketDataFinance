using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Infrastructure.CrossCutting.Bootstrap
{
    public class NativeBootstrap
    {
        public static void serviceLocation(IServiceCollection services)
        {
            services.AddScoped<IDataAppServices, DataAppServices>();
            services.AddScoped<IDataAdapter, DataAdapter>();

        }
    }
}
