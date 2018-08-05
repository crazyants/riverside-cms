﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Riverside.Cms.Services.Core.Client;

namespace Riverside.Cms.Services.Element.Domain
{
    public class FooterElementSettings : ElementSettings
    {
        public bool ShowLoggedOnUserOptions { get; set; }
        public bool ShowLoggedOffUserOptions { get; set; }
        public string Message { get; set; }
    }

    public class FooterElementContent : ElementContent
    {
        public string FormattedMessage { get; set; }
    }

    public interface IFooterElementService : IElementSettingsService<FooterElementSettings>, IElementContentService<FooterElementContent>
    {
    }

    public class FooterElementService : IFooterElementService
    {
        private readonly IElementRepository<FooterElementSettings> _elementRepository;

        public FooterElementService(IElementRepository<FooterElementSettings> elementRepository)
        {
            _elementRepository = elementRepository;
        }

        public Task<FooterElementSettings> ReadElementSettingsAsync(long tenantId, long elementId)
        {
            return _elementRepository.ReadElementSettingsAsync(tenantId, elementId);
        }

        private string FormatMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return null;
            return message.Replace("%YEAR%", DateTime.UtcNow.Year.ToString());
        }

        public async Task<FooterElementContent> ReadElementContentAsync(long tenantId, long elementId, PageContext context)
        {
            FooterElementSettings elementSettings = await _elementRepository.ReadElementSettingsAsync(tenantId, elementId);
            return new FooterElementContent
            {
                TenantId = tenantId,
                ElementId = elementId,
                ElementTypeId = elementSettings.ElementTypeId,
                FormattedMessage = FormatMessage(elementSettings.Message)
            };
        }
    }
}
