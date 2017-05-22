using HBSISLibraryWCF.DAL;
using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HBSISLibraryWCF.ServiceEntities;
using HBSISLibraryWCF.Util;

namespace HBSISLibraryWCF.BLL
{
    public static class BookBLL
    {
        public static List<Book> FindAll()
        {
            List<Book> bookList = new List<Book>();
            using (LibraryContext context = new LibraryContext())
            {
                List<BookEntity> dbBooksCollection = context.Books.Include(x => x.Publisher).Include(x => x.Authors).OrderBy(x => x.Title).ToList();

                bookList = dbBooksCollection.Select(x => new Book(x)).ToList();
            }

            return bookList;
        }


        public static Book FindBookById(int id)
        {
            Book book;

            using (LibraryContext context = new LibraryContext())
            {
                BookEntity dbBook = context.Books.FirstOrDefault(x => x.ID == id);
                book = dbBook == null ? null : new Book(dbBook);
            }

            return book;
        }

        public static Book InsertBook(Book book)
        {
            using (LibraryContext context = new LibraryContext())
            {
                DataContractObjectsTranslator.Instance.Context = context;
                var newBook = new BookEntity();
                DataContractObjectsTranslator.Instance.TranslateBookContractDataToBookEntity(book, ref newBook);

                int[] authorsIds = book.Authors.Select(a => a.ID).ToArray();
                List<AuthorEntity> newAuthorsList = context.Authors.Where(x => authorsIds.Contains(x.ID)).ToList();
                newBook.Authors = newAuthorsList;

                context.Books.Add(newBook);
                context.SaveChanges();
            }

            return book;
        }

        public static void DeleteBookById(int id)
        {
            BookEntity deletedBook;
            using (LibraryContext context = new LibraryContext())
            {
                deletedBook = context.Books.FirstOrDefault(x => x.ID == id);
                if (deletedBook != null)
                {
                    context.Books.Remove(deletedBook);
                    context.SaveChanges();
                }
            }
        }

        public static Book UpdateBook(Book book)
        {
            Book result = null;
            BookEntity originalBook;

            using (LibraryContext context = new LibraryContext())
            {
                originalBook = context.Books.FirstOrDefault(x => x.ID == book.ID);

                if (originalBook != null)
                {
                    
                    DataContractObjectsTranslator.Instance.Context = context;
                    DataContractObjectsTranslator.Instance.TranslateBookContractDataToBookEntity(book, ref originalBook);

                    int[] authorsIds = book.Authors.Select(a => a.ID).ToArray();
                    List<AuthorEntity> informedAuthors = context.Authors.Where(x => authorsIds.Contains(x.ID)).ToList();                    
                    var deletedAuthors = originalBook.Authors.Except(informedAuthors, x => x.ID).ToList();
                    var addedAuthors = informedAuthors.Except(originalBook.Authors, x => x.ID).ToList();

                    foreach (var delAuthor in deletedAuthors)
                    {
                        originalBook.Authors.Remove(delAuthor);
                    }

                    foreach (var addAuthor in addedAuthors)
                    {
                        originalBook.Authors.Add(addAuthor);
                    }

                    context.Entry(originalBook).State = EntityState.Modified;
                    context.SaveChanges();

                    result = new Book(originalBook);
                }
            }

            return result;
        }
    }
}