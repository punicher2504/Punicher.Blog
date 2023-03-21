namespace Punicher.Blog.Domain.Entity
{
	public class Post : BlogEntity
	{
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }        

        public Guid AuthorId { get; set; }
    }
}