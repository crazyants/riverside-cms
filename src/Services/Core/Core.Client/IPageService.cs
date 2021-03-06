﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Riverside.Cms.Services.Storage.Client;

namespace Riverside.Cms.Services.Core.Client
{
    public interface IPageService
    {
        Task<Page> ReadPageAsync(long tenantId, long pageId);
        Task<BlobContent> ReadPageImageAsync(long tenantId, long pageId, PageImageType pageImageType);

        Task<List<Page>> ListPagesInHierarchyAsync(long tenantId, long pageId);
        Task<IEnumerable<Page>> ListPagesAsync(long tenantId, IEnumerable<long> pageIds);
        Task<PageListResult> ListPagesAsync(long tenantId, long? parentPageId, bool recursive, PageType pageType, IEnumerable<long> tagIds, SortBy sortBy, bool sortAsc, int pageIndex, int pageSize);

        Task<List<PageZone>> SearchPageZonesAsync(long tenantId, long pageId);
        Task<PageZone> ReadPageZoneAsync(long tenantId, long pageId, long pageZoneId);

        Task<List<PageZoneElement>> SearchPageZoneElementsAsync(long tenantId, long pageId, long pageZoneId);
        Task<PageZoneElement> ReadPageZoneElementAsync(long tenantId, long pageId, long pageZoneId, long pageZoneElementId);
    }
}
