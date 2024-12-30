using SQLi.Challenge.Models;
using SQLi.Challenge.ViewModels;

namespace SQLi.Challenge.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        IEnumerable<Book> GetAllByTitle(string title);
        void AddBook(BookVM bookVM);
        void UpdateBook(int id, BookVM bookVM);
        void DeleteBook(int id);
    }
}
