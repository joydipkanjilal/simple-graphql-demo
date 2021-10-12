using BlogPostsManagementSystem.DataAccess.Models;
using HotChocolate.Types;

namespace BlogPostsManagementSystem.GraphQL
{
    public class BlogPostType : ObjectType<BlogPost>
    {
        protected override void Configure(IObjectTypeDescriptor<BlogPost> descriptor)
        {
            descriptor.Field(b => b.Id).Type<IdType>();
            descriptor.Field(b => b.Title).Type<StringType>();
            //descriptor.Field(b => b.Author.Id).Type<IntType>();
            descriptor.Field<AuthorResolver>(t => t.GetAuthor(default, default));
        }
    }
}
