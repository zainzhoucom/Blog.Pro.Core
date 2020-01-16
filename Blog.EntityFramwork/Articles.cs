using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.EntityFramework
{
	[Table("article")]
	public class Articles : BaseTable
	{
		[Required]
		[StringLength(128)]
		[DisplayName("标题")]
		[Column("title")]
		public string Title { get; set; }

		[DisplayName("内容")]
		[Column("content")]
		public string Content { get; set; }

		[DisplayName("创建时间")]
		[Column("createTime")]
		public DateTime CreateTime { get; set; }

		[DisplayName("简介")]
		[Column("intro")]
		public string Intro { get; set; }

		[DisplayName("简介配图")]
		[Column("introImage")]
		public string IntroImage { get; set; }

		[DisplayName("状态")]
		[Column("status")]
		public DataStatus Status { get; set; }

		[DisplayName("是否置顶")]
		[Column("isTop")]
		public bool Istop { get; set; }

		[DisplayName("主题")]
		[Column("genre")]
		public ArticleGenre Genre { get; set; }

		public ICollection<ArticleRelationShip> Tips { get; set; }
	}
}

