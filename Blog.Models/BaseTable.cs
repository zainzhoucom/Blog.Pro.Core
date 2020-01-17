using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class BaseTable
    {
        /// <summary>
        ///默认主键 guid 128
        /// </summary>
        [Key]
        [Required]
        [MaxLength(128)]
        [DisplayName("主键ID")]
        [Column("id", TypeName = "varchar(128)")]
        public string Id { get; set; }
    }

    public class BaseQueryListModel
    {
        public int page { get; set; }

        public int size { get; set; }
    }

    /// <summary>
    /// 表数据状态
    /// </summary>
    public enum DataStatus
    {
        /// <summary>
        /// 已删除
        /// </summary>
        Deleted = -1,
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 1
    }
}
