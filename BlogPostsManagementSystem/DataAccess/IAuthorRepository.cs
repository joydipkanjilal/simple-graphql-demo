using BlogPostsManagementSystem.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IAuthorRepository
{
    public List<Author> GetAuthors();
    public Author GetAuthorById(int id);
    public Task<Author> CreateAuthor(Author author);
}
