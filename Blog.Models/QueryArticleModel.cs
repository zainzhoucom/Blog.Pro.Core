using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Models
{
    public class QueryArticleModel : BaseQueryListModel
    {
        public string GenreId { get; set; }

        public string TipsId { get; set; }

        public string ArticleName { get; set; }
    }
}
