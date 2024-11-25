namespace ForumRomanum.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string UserID { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
