using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.EntityFramework
{
	[Table("tip")]
	public class Tips : BaseTable
	{
		[Required]
		[StringLength(50)]
		[DisplayName("标签名称")]
		[Column("genreName")]
		public string TipName { get; set; }

		[DisplayName("创建时间")]
		[Column("createTime")]
		public DateTime CreateTime { get; set; }

		[DisplayName("状态")]
		[Column("status")]
		public DataStatus Status { get; set; }

		public ICollection<ArticleRelationShip> Articles { get; set; }
	}
}

