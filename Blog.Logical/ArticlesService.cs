using Blog.EntityFramework;
using Blog.Logical.Interface;
using Blog.Models;
using Blog.Utils;
using Blog.Utils.Pager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Logical
{
    public class ArticlesService : IArticlesService
    {
        private readonly BloggingContext bloggingContext;
        public ArticlesService(BloggingContext context)
        {
            bloggingContext = context;
        }
        public async Task<PageData<ArticleViewModel>> QueryArticleListAsync(QueryArticleModel queryArticleModel)
        {
            PageData<ArticleViewModel> result = new PageData<ArticleViewModel>();

            try
            {
                Expression<Func<Articles, bool>> exp = SearchExpression.True<Articles>();
                if (!string.IsNullOrWhiteSpace(queryArticleModel.ArticleName))
                {
                    exp = exp.And(a => a.Title.Contains(queryArticleModel.ArticleName));
                }
                if (!string.IsNullOrWhiteSpace(queryArticleModel.GenreId))
                {
                    exp = exp.And(g => g.Genre.Id == queryArticleModel.GenreId);
                }
                if(!string.IsNullOrWhiteSpace(queryArticleModel.TipsId))
                {
                    exp = exp.And(t => t.Tips.Any(s => queryArticleModel.TipsId == s.TipId));
                }
                var query = bloggingContext.Articles.Where(exp);
                result.total = await query.CountAsync();
                result.page = queryArticleModel.page;
                result.size = queryArticleModel.size;
                List<Articles> articles = await query.OrderByDescending(c => c.CreateTime)
                    .Skip((queryArticleModel.page - 1) * queryArticleModel.size).Take(queryArticleModel.size).ToListAsync();
                result.list = new List<ArticleViewModel>();
                articles.ForEach(a =>
                {
                    result.list.Add(new ArticleViewModel
                    {
                        Id = a.Id,
                        Title = a.Title,
                        Intro = a.Intro,
                        IntroImage = a.IntroImage,
                        //Content = a.Content,
                        Genre = new ArticleGenreViewModel
                        {
                            Id = a.Genre.Id,
                            GenreName = a.Genre.GenreName,
                            CreateTime = a.Genre.CreateTime,
                            Status = a.Genre.Status
                        }
                    });
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
