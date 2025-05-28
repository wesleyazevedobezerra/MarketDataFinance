using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Factories
{
    public static class ScreenshotFactory
    {

        public static ScreenshotEntity SetEntityToViewModel(RootFinanceChartEntity entity)
        {
            return new ScreenshotEntity(entity.Chart.Result[0].Meta);




        }

    }
}
