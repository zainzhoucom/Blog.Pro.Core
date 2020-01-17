using Blog.Models;
using Blog.Utils.Pager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Logical.Interface
{
    public interface IArticlesService
    {
        /// <summary>
        /// 查询内容列表，分页
        /// </summary>
        /// <param name="queryArticleModel"></param>
        /// <returns></returns>
        public Task<PageData<ArticleViewModel>> QueryArticleListAsync(QueryArticleModel queryArticleModel);
    }
}
