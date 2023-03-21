namespace Punicher.Blog.Domain.Entity
{
	/// <summary>
	/// Base entity.
	/// </summary>
	public class BlogEntity
	{
		/// <summary>
		/// Creation date.
		/// </summary>
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Update date.
		/// </summary>
		public DateTime UpdatedAt { get; set; }
	}
}