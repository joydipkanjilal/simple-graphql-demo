using BlogPostsManagementSystem.DataAccess.Models;
using System.Collections.Generic;

public interface IBlogPostRepository
{
    public List<BlogPost> GetBlogPosts();
    public BlogPost GetBlogPostById(int id);
}

