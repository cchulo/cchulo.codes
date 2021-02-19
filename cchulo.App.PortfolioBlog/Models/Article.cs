﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cchulo.App.PortfolioBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Tag> tags { get; set; }
    }

    public class ArticlesType
    {
        public List<Article> Articles { get; set; }
    }
}
