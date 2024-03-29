﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using InstaCoreGraphAPI.Graph.Entity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace InstaCoreGraphAPI.Business.Interfaces
{
    public interface IInstaBusiness
    {
        string GetGraphApiUrl(string uri);

        List<SimpleMedia> GetMediasInsight(int limit, string cursorBefore, string cursorAfter);

        SimpleMedia GetMediaInsight(string id);

        SimpleMedia GetStoryInsight(string id);

        List<SimpleMedia> GetStoriesInsight();

        BusinessDiscovery GetBusinessDiscovery(string instagramId, string accountName);
    }
}
