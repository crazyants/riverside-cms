﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Riverside.Cms.Services.Core.Client;

namespace Riverside.Cms.Services.Element.Client
{
    public class TagCloudElementSettings : ElementSettings
    {
        public bool Recursive { get; set; }
        public long? PageId { get; set; }
        public string DisplayName { get; set; }
        public string NoTagsMessage { get; set; }
    }

    public class TagCloudElementContent
    {
    }

    public interface ITagCloudElementService : IElementSettingsService<TagCloudElementSettings>, IElementViewService<TagCloudElementSettings, TagCloudElementContent>
    {
    }

    public class TagCloudElementService : ITagCloudElementService
    {
        private readonly IOptions<ElementApiOptions> _options;

        public TagCloudElementService(IOptions<ElementApiOptions> options)
        {
            _options = options;
        }

        public async Task<TagCloudElementSettings> ReadElementSettingsAsync(long tenantId, long elementId)
        {
            try
            {
                string uri = $"{_options.Value.ElementApiBaseUrl}tenants/{tenantId}/elementtypes/b910c231-7dbd-4cad-92ef-775981e895b4/elements/{elementId}";
                using (HttpClient httpClient = new HttpClient())
                {
                    string json = await httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObject<TagCloudElementSettings>(json);
                }
            }
            catch (Exception ex)
            {
                throw new ElementClientException("Element API failed", ex);
            }
        }

        public async Task<IElementView<TagCloudElementSettings, TagCloudElementContent>> ReadElementViewAsync(long tenantId, long elementId, PageContext context)
        {
            try
            {
                string uri = $"{_options.Value.ElementApiBaseUrl}tenants/{tenantId}/elementtypes/b910c231-7dbd-4cad-92ef-775981e895b4/elements/{elementId}/view?pageid={context.PageId}";
                using (HttpClient httpClient = new HttpClient())
                {
                    string json = await httpClient.GetStringAsync(uri);
                    return JsonConvert.DeserializeObject<ElementView<TagCloudElementSettings, TagCloudElementContent>>(json);
                }
            }
            catch (Exception ex)
            {
                throw new ElementClientException("Element API failed", ex);
            }
        }
    }
}
