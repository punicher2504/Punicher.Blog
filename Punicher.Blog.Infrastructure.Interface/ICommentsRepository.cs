using Punicher.Blog.Domain.Entity;

namespace Punicher.Blog.Infrastructure.Interface
{
	/// <summary>
	/// Comment repository.
	/// </summary>
	public interface ICommentsRepository
	{
		/// <summary>
		/// Get a list of comments for a post, with optional pagination..
		/// </summary>
		/// <param name="postId">Post Id.</param>
		/// <returns>A list of comments for a post.</returns>
		Task<IEnumerable<Comment>> GetAllAsync(Guid postId);

		/// <summary>
		/// Gets a single comment given a post.
		/// </summary>
		/// <param name="postId">Post id.</param>
		/// <param name="commentId">Comment id.</param>
		/// <returns>The specific blog post.</returns>
		Task<IEnumerable<Comment>> GetAsync(
			Guid postId, 
			Guid commentId);

		/// <summary>
		/// Creates a new comment for a post.
		/// </summary>
		/// <param name="comment">New comment info</param>
		/// <returns>New comment id.</returns>
		Task<Guid> CreateAsync(Comment comment);

		/// <summary>
		/// Updates all or part of an existing comment for a post.
		/// </summary>
		/// <param name="post">Comment info.</param>
		/// <returns>True/False: Operation result.</returns>
		Task<bool> UpdateAsync(Comment comment);

		/// <summary>
		/// Deletes a specific comment for a blog post.
		/// </summary>
		/// <param name="id">Comment id.</param>
		/// <returns>True/False: Operation result.</returns>
		Task<bool> DeleteAsync(Guid id);
	}
}