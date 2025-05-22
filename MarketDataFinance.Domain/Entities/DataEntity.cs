using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class DataEntity
    {
        public long LastUpdated { get; set; }
        public string Id { get; set; }
        public int Total { get; set; }
        public bool PredefinedScr { get; set; }
        public string Description { get; set; }
        public int VersionId { get; set; }
        public bool UseRecords { get; set; }
        public int Count { get; set; }
        public bool IsPremium { get; set; }
        public int Start { get; set; }
        public string Title { get; set; }
        public List<QuoteEntity> Quotes { get; set; }
        public CriteriaMetaEntity CriteriaMeta { get; set; }
        public string IconUrl { get; set; }
        public long CreationDate { get; set; }
        public string RawCriteria { get; set; }
        public string CanonicalName { get; set; }
    }

    public class Datum
    {
        public OptionsEntity options { get; set; }
        public string underlyingSymbol { get; set; }
        public QuoteEntity quote { get; set; }
        public bool hasMiniOptions { get; set; }
        public ExpirationDatesEntity expirationDates { get; set; }
        public StrikesEntity strikes { get; set; }
    }

    public class ExpirationDatesEntity
    {
    }
    public class StrikesEntity
    {
    }
    public class OptionsEntity
    {
    }

}
