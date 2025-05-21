using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Factories
{
    public class DataFactory
    {
        public static DataViewModel CreateDataFactory(DataEntity entity)
        {
            return new DataViewModel(entity.LastUpdated, entity.Id, entity.Total, entity.PredefinedScr, entity.Description, entity.VersionId, entity.UseRecords, entity.Count, entity.IsPremium, entity.Start, entity.Title, entity.Quotes, entity.CriteriaMeta, entity.IconUrl, entity.CreationDate, entity.RawCriteria, entity.CanonicalName);
        }
    }
}
