using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.EntityFramework
{
    [Table("articleGenre")]
    public class ArticleGenre : BaseTable
    {
        [Required]
        [StringLength(50)]
        [DisplayName("主题名称")]
        [Column("genreName")]
        public string GenreName { get; set; }

        [DisplayName("创建时间")]
        [Column("createTime")]
        public DateTime CreateTime { get; set; }

        [DisplayName("状态")]
        [Column("status")]
        public DataStatus Status { get; set; }

        public List<Articles> Articles { get; set; }
    }
}
