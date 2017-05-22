using HBSISLibraryWCF.DAL;
using HBSISLibraryWCF.Models;
using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.Util
{
    public class DataContractObjectsTranslator
    {
        public LibraryContext Context { get; set; }

        private static DataContractObjectsTranslator instance;

        private DataContractObjectsTranslator() { }

        public static DataContractObjectsTranslator Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new DataContractObjectsTranslator();
                }
                return instance;
            }
        }

        public void TranslateBookContractDataToBookEntity(Book bookContract, ref BookEntity bookEntity)
        {
            bookEntity.ID = bookContract.ID;
            bookEntity.Title = bookContract.Title;
            bookEntity.ISBN = bookContract.ISBN;
            bookEntity.Pages = bookContract.Pages;
            bookEntity.Description = bookContract.Description;

            PublisherEntity newPublisher = this.Context.Publishers.FirstOrDefault(x => bookContract.Publisher.ID == x.ID);
            bookEntity.Publisher = newPublisher;
        }

        public static AuthorEntity TranslateAuthorContractDataToAuthorEntity(Author authorContract)
        {
            var authorEntity = new AuthorEntity();

            authorEntity.ID = authorContract.ID;
            authorEntity.FirstName = authorContract.FirstName;
            authorEntity.LastName = authorContract.LastName;

            return authorEntity;
        }

        public static PublisherEntity TranslatePublisherContractDataToPublisherEntity(Publisher publisherContract)
        {
            var publisherEntity = new PublisherEntity();

            publisherEntity.ID = publisherContract.ID;
            publisherEntity.PublisherName = publisherContract.PublisherName;
            publisherEntity.Location = publisherContract.Location;

            return publisherEntity;
        }
    }
}