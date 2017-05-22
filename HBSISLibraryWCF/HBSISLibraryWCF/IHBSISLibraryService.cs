using HBSISLibraryWCF.ServiceEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HBSISLibraryWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHBSISLibraryService" in both code and config file together.
    [ServiceContract]
    public interface IHBSISLibraryService
    {
        [OperationContract]
        List<Book> FindAllBooks();

        [OperationContract]
        Book FindBookById(int id);

        [OperationContract]
        Book InsertBook(Book book);

        [OperationContract]
        Book UpdateBook(Book book);

        [OperationContract]
        void DeleteBookById(int id);

        [OperationContract]
        List<Publisher> FindAllPublishers();

        [OperationContract]
        List<Author> FindAllAuthors();
    }
}
