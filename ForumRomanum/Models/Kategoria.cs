namespace ForumRomanum.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int UserID { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
        public User User { get; set; }
    }
}
