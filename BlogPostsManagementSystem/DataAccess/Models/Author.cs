using HotChocolate;
using HotChocolate.Types;

namespace BlogPostsManagementSystem.DataAccess.Models
{
    public class Author
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }

        [GraphQLNonNullType]
        public string FirstName { get; set; }

        [GraphQLNonNullType]
        public string LastName { get; set; }
    }
}