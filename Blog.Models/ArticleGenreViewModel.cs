using System;

namespace Blog.Models
{
    public class ArticleGenreViewModel
    {
        public string Id { get; set; }

        public string GenreName { get; set; }

        public DateTime CreateTime { get; set; }

        public DataStatus Status { get; set; }
    }
}
