using Punicher.Blog.Domain.Entity;
using Punicher.Blog.Infrastructure.Interface;

namespace Punicher.Blog.Infrastructure.Repository
{
	/// <summary>
	/// <see cref="ICommentsRepository"/>
	/// </summary>
	public class CommentsRepository : ICommentsRepository
	{
		#region Methods
		/// <summary>
		/// <see cref="ICommentsRepository.CreateAsync(Comment)"/>
		/// </summary>
		public Task<Guid> CreateAsync(Comment comment)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="ICommentsRepository.DeleteAsync(Guid)"/>
		/// </summary>
		public Task<bool> DeleteAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="ICommentsRepository.GetAllAsync(Guid)"/>
		/// </summary>
		public Task<IEnumerable<Comment>> GetAllAsync(Guid postId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="ICommentsRepository.GetAsync(Guid, Guid)"/>
		/// </summary>
		public Task<IEnumerable<Comment>> GetAsync(
			Guid postId, 
			Guid commentId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="ICommentsRepository.UpdateAsync(Comment)"/>
		/// </summary>
		public Task<bool> UpdateAsync(Comment comment)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}