﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Riverside.Cms.Services.Element.Domain
{
    public interface IElementContentService<T> where T : IElementContent
    {
        Task<T> ReadElementContentAsync(long tenantId, long elementId, long pageId, IEnumerable<long> tagIds);
    }
}
