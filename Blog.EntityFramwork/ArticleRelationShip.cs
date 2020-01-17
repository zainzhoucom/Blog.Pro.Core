namespace Blog.EntityFramework
{
    public class ArticleRelationShip
    {
        public string ArticleId { get; set; }
        public Articles Articles { get; set; }

        public string TipId { get; set; }

        public Tips Tips { get; set; }
    }
}
