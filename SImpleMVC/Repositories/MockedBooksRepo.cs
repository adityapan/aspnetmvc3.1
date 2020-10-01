using System;
using System.Collections.Generic;
using System.Linq;
using SImpleMVC.Models;

namespace SImpleMVC.Repositories
{
    public class MockedBooksRepo : IBooksRepository
    {
        private ICategoryRepository _categoryRepository;

        public MockedBooksRepo(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return AllBooks();
        }

        private static IEnumerable<Book> AllBooks()
        {
            return new List<Book> {
                new Book{ Id = 1, Author = "Jerry", Isbn="1011", Category = null, Name="How I hate Tom!", Price =9.99m },
                new Book{ Id = 2, Author = "Jerry", Isbn="1012", Category = null, Name="My roomate Tom", Price =19.99m },
                new Book{ Id = 3, Author = "Tom", Isbn="1022", Category = null, Name="How I love Jerry!", Price =9.99m },
                new Book{ Id = 4, Author = "Tom", Isbn = "1023", Category = null, Name = "My bestfriend Jerry", Price = 19.99m }
            };
        }

        public Book GetBookById(int id)
        {
            return AllBooks().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooksOfTheWeek()
        {
            throw new NotImplementedException();
        }
    }
}
