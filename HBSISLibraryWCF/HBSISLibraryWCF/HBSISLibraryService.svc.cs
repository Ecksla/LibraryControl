using HBSISLibraryWCF.BLL;
using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HBSISLibraryWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HBSISLibraryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HBSISLibraryService.svc or HBSISLibraryService.svc.cs at the Solution Explorer and start debugging.
    public class HBSISLibraryService : IHBSISLibraryService
    {
        /// <summary>
        /// Returns all books in database
        /// </summary>
        /// <returns>A list of books</returns>
        public List<Book> FindAllBooks()
        {
            return BookBLL.FindAll();
        }

        /// <summary>
        /// Find and return a book according to the id parameter
        /// </summary>
        /// <param name="id">The book id used as filter</param>
        /// <returns>The found book</returns>
        public Book FindBookById(int id)
        {
            return BookBLL.FindBookById(id);
        }

        /// <summary>
        /// Insert a new book in the database
        /// </summary>
        /// <param name="book">The book  to be inserted</param>
        /// <returns>A model of the inserted book</returns>
        public Book InsertBook(HBSISLibraryWCF.ServiceEntities.Book book)
        {
            return BookBLL.InsertBook(book);
        }

        /// <summary>
        /// Update the informations of a book in the database
        /// </summary>
        /// <param name="book">The book to be updated</param>
        /// <returns>A model of the updated book</returns>
        public Book UpdateBook(HBSISLibraryWCF.ServiceEntities.Book book)
        {
            return BookBLL.UpdateBook(book);
        }

        /// <summary>
        /// Delete a book of the database by it's id
        /// </summary>
        /// <param name="id">The id of the book to be deleted</param>
        public void DeleteBookById(int id)
        {
            BookBLL.DeleteBookById(id);
        }

        /// <summary>
        /// Returns all publishers in database
        /// </summary>
        /// <returns>A list of publishers</returns>
        public List<Publisher> FindAllPublishers()
        {
            return PublisherBLL.FindAll();
        }

        /// <summary>
        /// Returns all authors in database
        /// </summary>
        /// <returns>A list of authors</returns>
        public List<Author> FindAllAuthors()
        {
            return AuthorBLL.FindAll();
        }
    }
}
