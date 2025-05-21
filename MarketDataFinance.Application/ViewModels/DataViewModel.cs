using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public record class DataViewModel(long lastUpdated, string Id, int Total, bool PredefinedScr, string Description, int VersionId, bool UseRecords, int Count, bool IsPremium, int Start, string Title, List<QuoteEntity> Quotes, CriteriaMetaEntity CriteriaMeta, string IconUrl, long CreationDate, string RawCriteria, string CanonicalName);
}
