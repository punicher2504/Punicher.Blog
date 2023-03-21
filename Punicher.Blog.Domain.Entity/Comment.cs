namespace Punicher.Blog.Domain.Entity
{
	public class Comment : BlogEntity
	{
		/// <summary>
		/// Comment id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Post id.
		/// </summary>
		public Guid PostId { get; set; }

		/// <summary>
		/// Author's user name.
		/// </summary>
		public string? UserName { get; set; }

		/// <summary>
		/// Author's email(if not registered).
		/// </summary>
		public string? UserEmail { get; set; }

		/// <summary>
		/// Content of the comment.
		/// </summary>
		public string? Content { get; set; }
   }
}