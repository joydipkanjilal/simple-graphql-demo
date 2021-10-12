using BlogPostsManagementSystem.DataAccess;
using BlogPostsManagementSystem.DataAccess.Models;
using HotChocolate;
using HotChocolate.Subscriptions;
using System.Threading.Tasks;

namespace BlogPostsManagementSystem.GraphQL
{
    public class Mutation
    {
        public async Task<Author> CreateAuthor([Service] IAuthorRepository authorRepository,
            [Service] ITopicEventSender eventSender, int id, string firstName,string lastName)
        {
            var data = new Author
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
            var result = await authorRepository.CreateAuthor(data);

            await eventSender.SendAsync("AuthorCreated", result);

            return result;
        }
    }
}
