using HBSISLibraryWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBSISLibraryWCF.DAL
{
    public class LibraryCollectionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var publishers = new List<PublisherEntity>
            {
                new PublisherEntity() { ID=1000, Location="Brasil", PublisherName="Sexante" },
                new PublisherEntity() { ID=1010, Location="Brasil", PublisherName="Martins Fontes"},
                new PublisherEntity() { ID=1020, Location="Estados Unidos", PublisherName="Addison-Wesley Professional"}                
            };

            publishers.ForEach(x => context.Publishers.Add(x));
            context.SaveChanges();

            var authors = new List<AuthorEntity>
            {
                new AuthorEntity() { ID=1, FirstName="Paulo", LastName="Coelho" },
                new AuthorEntity() { ID=2, FirstName="J.R.R.", LastName="Tolkien" },
                new AuthorEntity() { ID=3, FirstName="Andrew", LastName="Hunt" },
                new AuthorEntity() { ID=4, FirstName="David", LastName="Thomas" }
            };
            authors.ForEach(x => context.Authors.Add(x));
            context.SaveChanges();

            var books = new List<BookEntity>
            {
                new BookEntity() 
                {
                    Authors=new List<AuthorEntity>(authors.Where(x => x.ID == 1)),
                    Description="O alquimista é a mágica história de Santiago, um menino pastor andaluz que anseia por viajar em busca do tesouro mais magnífico do mundo. De sua casa na Espanha ele parte para os mercados do Tânger e através do deserto egípcio para um encontro do destino com o alquimista ...",
                    ISBN="9788575427583",
                    Pages=176,
                    PublisherID=1000,
                    Title="O Alquimista"
                },
                new BookEntity() 
                {
                    Authors = new List<AuthorEntity>(authors.Where(x => x.ID == 2)),
                    Description = "Numa cidadezinha indolente do Condado, um jovem hobbit é encarregado de uma imensa tarefa. Deve empreender uma perigosa viagem através da Terra-média até as Fendas da Perdição, e lá destruir o Anel do Poder - a única coisa que impede o domínio maléfico do Senhor do Escuro.",
                    ISBN = "9788533613379",
                    Pages = 464,
                    PublisherID = 1010,
                    Title = "O Senhor do Aneis - A Sociedade do Anel"
                },
                new BookEntity() 
                {
                    Authors = new List<AuthorEntity>(authors.Where(x => x.ID == 3 || x.ID == 4).ToArray()),
                    Description = "What others in the trenches say about The Pragmatic Programmer... “The cool thing about this book is that it’s great for keeping the programming process fresh.",
                    Pages = 352,
                    PublisherID = 1010,
                    Title = "The Pragmatic Programmer: From Journeyman to Master"
                }
            };
            books.ForEach(x => context.Books.Add(x));
            context.SaveChanges();
        }
    }
}