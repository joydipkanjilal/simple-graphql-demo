using BlogPostsManagementSystem.DataAccess;
using BlogPostsManagementSystem.DataAccess.Models;
using HotChocolate;
using HotChocolate.Resolvers;
using System.Collections.Generic;
using System.Linq;

namespace BlogPostsManagementSystem.GraphQL
{
    public class BlogPostResolver
    {
        private readonly IBlogPostRepository
        _blogPostRepository;
        public BlogPostResolver([Service]
        IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        public IEnumerable<BlogPost> GetBlogPosts(
        Author author, IResolverContext ctx)
        {
            return _blogPostRepository.GetBlogPosts()
            .Where(b => b.AuthorId == author.Id);
        }
    }
}
