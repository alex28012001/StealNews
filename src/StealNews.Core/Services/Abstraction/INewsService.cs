﻿using StealNews.Model.Entities;
using System.Collections.Generic;
using StealNews.Model.Models.Service.News;

namespace StealNews.Core.Services.Abstraction
{
    public interface INewsService
    {
        IEnumerable<News> Find(NewsFindFilter filter);
    }
}
