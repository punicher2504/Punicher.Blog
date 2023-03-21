namespace Punicher.Blog.Domain.Entity
{
	public class Author : BlogEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }
   }
}