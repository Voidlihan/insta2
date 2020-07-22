namespace Domain.Model
{
    public class Comment : Enitity
    {
        public string Text { get; set; }
        public string CommentAuthor { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}