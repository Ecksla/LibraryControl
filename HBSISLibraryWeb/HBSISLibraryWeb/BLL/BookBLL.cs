using HBSISLibraryWeb.HBSISLibraryServiceReference;
using HBSISLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HBSISLibraryWeb.Util;

namespace HBSISLibraryWeb.BLL
{
    public static class BookBLL
    {
        public static List<BookModel> ListAll()
        {
            List<BookModel> result = new List<BookModel>();

            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                result = client.FindAllBooks().Select(x => new BookModel(x)).ToList();
            }

            return result;
        }

        public static BookModel Update(BookModel book)
        {
            Book insertedBook;
            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                Book serviceBook = new Book();

                serviceBook.ID = book.ID;
                serviceBook.Title = book.Title;
                serviceBook.ISBN = book.ISBN;
                serviceBook.Pages = book.Pages;
                serviceBook.Description = book.Description;

                var serviceAuthors = new List<Author>();
                foreach (var authorItem in book.Authors)
                {
                    var serviceAuthor = new Author();
                    serviceAuthor.ID = authorItem.ID;
                    serviceAuthors.Add(serviceAuthor);
                }

                serviceBook.Authors = serviceAuthors.ToArray();

                var servicePublisher = new Publisher();
                servicePublisher.ID = book.Publisher.ID;
                serviceBook.Publisher = servicePublisher;

                insertedBook = client.UpdateBook(serviceBook);
            }

            return insertedBook == null ? null : new BookModel(insertedBook);
        }

        public static BookModel Insert(BookModel book)
        {
            Book insertedBook;
            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                Book serviceBook = new Book();
                serviceBook.Title = book.Title;
                serviceBook.ISBN = book.ISBN;
                serviceBook.Pages = book.Pages;
                serviceBook.Description = book.Description;

                var serviceAuthors = new List<Author>();
                foreach (var authorItem in book.Authors)
                {
                    var serviceAuthor = new Author();
                    serviceAuthor.ID = authorItem.ID;
                    serviceAuthors.Add(serviceAuthor);
                }

                serviceBook.Authors = serviceAuthors.ToArray();

                var servicePublisher = new Publisher();
                servicePublisher.ID = book.Publisher.ID;
                serviceBook.Publisher = servicePublisher;

                insertedBook = client.InsertBook(serviceBook);
            }

            return insertedBook == null ? null : new BookModel(insertedBook);
        }

        public static BookModel FindBookById(int id)
        {
            BookModel result = null;

            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                Book retrievedBook = client.FindBookById(id);
                if(retrievedBook != null)
                {
                    result = new BookModel(retrievedBook);
                }                
            }

            return result;
        }

        public static void DeleteById(int id)
        {
            HBSISLibraryServiceClient client = new HBSISLibraryServiceClient();
            using (client.AsDisposable())
            {
                client.DeleteBookById(id);
            }
        }
    }
}