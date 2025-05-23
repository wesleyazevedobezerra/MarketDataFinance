using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class DatumNewsViewModel
    {
        public List<string> Tickers { get; set; }
        public string ThumbSmall { get; set; }
        public string FollowersType { get; set; }
        public string HostedType { get; set; }
        public string ThumbMedium { get; set; }
        public string ArticleUrl { get; set; }
        public string NotificationType { get; set; }
        public string ContentType { get; set; }
        public object PublishTs { get; set; }
        public string Region { get; set; }
        public string Lang { get; set; }
        public MetaNewsViewModel Meta { get; set; }
        public string ContentId { get; set; }
        public string Cta { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
        public string NotificationTitle { get; set; }
        public int Score { get; set; }
        public string Body { get; set; }
        public string Type { get; set; }
    }
}
