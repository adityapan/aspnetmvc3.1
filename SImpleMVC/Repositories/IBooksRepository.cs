using System.Collections.Generic;
using SimpleMVC.Models;

namespace SimpleMVC.Repositories
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetBooksOfTheWeek();
        Book GetBookById(int id);
    }
}
