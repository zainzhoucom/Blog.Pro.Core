using System;
using System.Collections.Generic;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        public string Id { get; set; }

		public string Title { get; set; }

		public string Content { get; set; }

		public DateTime CreateTime { get; set; }

		public string Intro { get; set; }

		public string IntroImage { get; set; }

		public DataStatus Status { get; set; }

		public bool Istop { get; set; }

		public ArticleGenreViewModel Genre { get; set; }

		public List<TipsViewModel> Tips { get; set; }

	}
}
