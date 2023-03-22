using Punicher.Blog.Domain.Entity;
using Punicher.Blog.Infrastructure.Interface;

namespace Punicher.Blog.Infrastructure.Repository
{
	/// <summary>
	/// <see cref="IPostsRepository"/>
	/// </summary>
	public class PostsRepository : IPostsRepository
	{
		#region Methods
		/// <summary>
		/// <see cref="IPostsRepository.CreateAsync(Post)"/>
		/// </summary>
		public Task<Guid> CreateAsync(Post post)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="IPostsRepository.DeleteAsync(Guid)"/>
		/// </summary>
		public Task<bool> DeleteAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="IPostsRepository.GetAllAsync"/>
		/// </summary>
		public Task<IEnumerable<Post>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="IPostsRepository.GetAsync(Guid)"/>
		/// </summary>
		public Task<Post> GetAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// <see cref="IPostsRepository.UpdateAsync(Post)"/>
		/// </summary>
		public Task<bool> UpdateAsync(Post post)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}