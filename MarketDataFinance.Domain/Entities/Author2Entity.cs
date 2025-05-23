using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MarketDataFinance.Domain.Entities
{
    public class Author2Entity
    {
        public string Byline { get; set; }
        public string DisplayName { get; set; }
        public ImageEntity Image { get; set; }
        public string Description { get; set; }
    }
}
