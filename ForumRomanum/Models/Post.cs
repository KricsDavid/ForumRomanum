namespace ForumRomanum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int TopicID { get; set; }
        public string UserID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
        public int Reply {  get; set; }
        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}
