using System;
using System.Collections.Generic;
using System.Text;
using WebCoreTest_1.Data.Enums;
using WebCoreTest_1.Data.Interfaces;
using WebCoreTest_1.Infrastructure.SharedKernel;

namespace WebCoreTest_1.Data.Entities
{
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Status Status { get; set; }
        public int SorOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
