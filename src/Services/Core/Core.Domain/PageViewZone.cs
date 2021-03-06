﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Riverside.Cms.Services.Core.Domain
{
    public class PageViewZone
    {
        public long TenantId { get; set; }

        public long MasterPageId { get; set; }
        public long MasterPageZoneId { get; set; }
        public long PageId { get; set; }

        public string BeginRender { get; set; }
        public string EndRender { get; set; }

        public IEnumerable<PageViewZoneElement> PageViewZoneElements { get; set; }
    }
}
