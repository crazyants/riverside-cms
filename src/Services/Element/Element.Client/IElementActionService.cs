﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Riverside.Cms.Services.Element.Client
{
    public interface IElementActionService<TRequest, TResponse>
    {
        Task<TResponse> PerformElementActionAsync(long tenantId, long elementId, TRequest request, IPageContext context);
    }
}
