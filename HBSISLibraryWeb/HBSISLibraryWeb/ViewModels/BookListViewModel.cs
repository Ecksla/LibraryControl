using HBSISLibraryWeb.HBSISLibraryServiceReference;
using HBSISLibraryWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBSISLibraryWeb.ViewModels
{
    public class BookListViewModel
    {
        public BookListViewModel()
        {
        }

        public BookListViewModel(BookModel book)
        {
            this.BookID = book.ID;
            this.Title = book.Title;
            this.Pages = book.Pages;
            this.ISBN = book.ISBN;
            this.Description = book.Description;
            this.PublisherName = book.Publisher.PublisherName;
        }

        [Display(Name="Editora")]
        public string PublisherName { get; set; }

        [Display(Name = "Páginas")]
        [Required(ErrorMessage="O campo Páginas é obrigatório.")]
        public int? Pages { get; set; }

        [Display(Name = "ISBN")]
        [Required(ErrorMessage="O campo ISBN é obrigatório.")]
        public string ISBN { get; set; }

        public int BookID { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage="O campo Título é obrigatório.")]
        public string Title { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public string Description { get; set; }
    }
}