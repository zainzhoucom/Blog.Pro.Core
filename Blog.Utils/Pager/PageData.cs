using System.Collections.Generic;

namespace Blog.Utils.Pager
{
    /// <summary>
    /// 分页模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageData<T> where T : new()
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int size { get; set; }
        /// <summary>
        /// 总数据
        /// </summary>
        public long total { get; set; }
        /// <summary>
        /// 数据列表
        /// </summary>
        public List<T> list { get; set; }
    }
}
