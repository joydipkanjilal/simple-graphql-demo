using BlogPostsManagementSystem.DataAccess.Models;
using HotChocolate.Types;

namespace BlogPostsManagementSystem.GraphQL
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor.Field(a => a.Id).Type<IdType>();
            descriptor.Field(a => a.FirstName).Type<StringType>();
            descriptor.Field(a => a.LastName).Type<StringType>();
            descriptor.Field<BlogPostResolver>(b => b.GetBlogPosts(default, default));
        }
    }
}
