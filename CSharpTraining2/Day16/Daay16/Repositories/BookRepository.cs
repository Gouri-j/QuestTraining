using Daay16.Data;
using Daay16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daay16.Repositories
{
    internal class BookRepository
    {
        public GenericResponse<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponse<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }

        public GenericResponse<Book> GetBookById(int Bookid)
        {
            var bok = DataStore.Books.FirstOrDefault(b => b.BookId == Bookid);
            if (bok == null)
            {
                return new GenericResponse<Book>
                {
                    Success = false,
                    Message = "Book not found",
                };
            }

            return new GenericResponse<Book>
            {
                Success = true,
                Data = bok,
            };

        }
    }
}
