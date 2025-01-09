namespace BlogV1.Models.ViewModels
{
    public class DashboardViewModel
    {
        //toplam blog sayisi
        public int TotalBlogCount { get; set; }
        //toplam goruntulenme sayisi
        public int TotalViewCount { get; set; }
        //en cok goruntulneneblog
        public Blog MostViewedBlog { get; set; }
        //en son yayinlanan blog
        public Blog LatestBlog { get; set; }
        //toplam yorum sayisi
        public int TotalCommentCount { get; set; }
        //en cok yorum alan blog
        public Blog MostCommentedBlog { get; set; }
        //bugun yapilan yorum sayisi
        public int TodayCommentCount { get; set; }
    }
}
