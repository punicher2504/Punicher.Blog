namespace Punicher.Blog.Domain.Entity
{
	/// <summary>	
	/// Author of a comment or a post.
	/// </summary>
	public class Author : BlogEntity
	{
		/// <summary>
		/// Author's id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Author's name.
		/// </summary>
		public string? Name { get; set; }

		/// <summary>
		/// Author's email.
		/// </summary>
		public string? Email { get; set; }
   }
}