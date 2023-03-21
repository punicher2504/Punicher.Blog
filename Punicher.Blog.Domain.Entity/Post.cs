namespace Punicher.Blog.Domain.Entity
{
   /// <summary>
   /// Post in the blog.
   /// </summary>
	public class Post : BlogEntity
	{
      /// <summary>
      /// Post id.
      /// </summary>
      public Guid Id { get; set; }

      /// <summary>
      /// Title of the post.
      /// </summary>
      public string? Title { get; set; }

      /// <summary>
      /// Content of the post.
      /// </summary>
      public string? Content { get; set; }        

      /// <summary>
      /// Author's id.
      /// </summary>
      public Guid AuthorId { get; set; }
    }
}