namespace Punicher.Blog.Domain.Entity
{
	public class Comment : BlogEntity
	{
		public Guid Id { get; set; }

		public Guid PostId { get; set; }

		public string UserName { get; set; }

		public string UserEmail { get; set; }

		public string Content { get; set; }
   }
}