using System;
using System.Collections.Generic;
using SImpleMVC.Models;

namespace SImpleMVC.Repositories
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetBooksOfTheWeek();
        Book GetBookById(int id);
    }
}
