using Punicher.Blog.Domain.Entity;

namespace Punicher.Blog.Infrastructure.Interface
{
	/// <summary>
	/// Post repository.
	/// </summary>
	public interface IPostsRepository
	{
		/// <summary>
		/// Get a list of all posts, with optional pagination.
		/// </summary>
		/// <returns>A list of all posts.</returns>
		Task<IEnumerable<Post>> GetAllAsync();

		/// <summary>
		/// Gets a single post.
		/// </summary>
		/// <param name="id">Post id.</param>
		/// <returns>The specific blog post.</returns>
		Task<Post> GetAsync(Guid id);

		/// <summary>
		/// Creates a new post.
		/// </summary>
		/// <param name="post">New post info.</param>
		/// <returns>New post id.</returns>
		Task<Guid> CreateAsync(Post post);

		/// <summary>
		/// Updates all or part of a specific post.
		/// </summary>
		/// <param name="post">Post info.</param>
		/// <returns>True/False: Operation result.</returns>
		Task<bool> UpdateAsync(Post post);

		/// <summary>
		/// Deletes a post.
		/// </summary>
		/// <param name="id">Post id.</param>
		/// <returns>True/False: Operation result.</returns>
		Task<bool> DeleteAsync(Guid id);
	}
}