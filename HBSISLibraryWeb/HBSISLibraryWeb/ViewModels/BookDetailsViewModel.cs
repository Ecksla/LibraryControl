using HBSISLibraryWeb.Models;
using HBSISLibraryWeb.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBSISLibraryWeb.ViewModels
{
    public class BookDetailsViewModel : BookListViewModel
    {
        public BookDetailsViewModel()
        {
            this.SelectedAuthors = new List<string>();
            this.PublisherList = new List<PublisherModel>();
            this.AuthorsList = new List<AuthorModel>();
        }

        public BookDetailsViewModel(BookModel book) : base(book)
        {
            this.PublisherList = new List<PublisherModel>();
            
            this.AuthorsList = new List<AuthorModel>();           
            this.SelectedPublisher = book.Publisher.ID.ToString();

            this.SelectedAuthors = book.Authors.Select(x => x.ID.ToString()).ToList();
        }

        [Required(ErrorMessage="O campo Editora é obrigatório.")]
        [Display(Name = "Editora")]
        public string SelectedPublisher { get; set; }

        [EnsureOneElementAttribute(ErrorMessage = "O campo Autor(es) é obrigatório.")]
        [Display(Name = "Autor(es)")]
        public IList<string> SelectedAuthors { get; set; }

        public List<PublisherModel> PublisherList { get; set; }        
        public List<AuthorModel> AuthorsList { get; set; }
    }
}