using HBSISLibraryWeb.BLL;
using HBSISLibraryWeb.Models;
using HBSISLibraryWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HBSISLibraryWeb.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
            List<BookModel> bookList = BookBLL.ListAll();
            List<BookListViewModel> bookViewModelList = bookList.Select(x => new BookListViewModel(x)).ToList();
            return View(bookViewModelList);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookModel book = BookBLL.FindBookById(id.Value);

            if (book == null)
            {
                return HttpNotFound();
            }

            var bookViewModel = new BookDetailsViewModel(book);

            bookViewModel.BookID = id.Value;
            bookViewModel.PublisherList = PublisherBLL.ListAll();

            bookViewModel.AuthorsList = book.Authors;

            return View(bookViewModel);
        }

        public ActionResult Create()
        {
            var bookViewModel = new BookDetailsViewModel();

            bookViewModel.PublisherList = PublisherBLL.ListAll();
            bookViewModel.AuthorsList = AuthorBLL.ListAll();
            return View(bookViewModel);  
        }

        private BookModel ConvertBookDetailsViewModelToBookModel(BookDetailsViewModel bookViewModel)
        {
            var bookModel = new BookModel();
            bookModel.Title = bookViewModel.Title;
            bookModel.ISBN = bookViewModel.ISBN;
            bookModel.Pages = bookViewModel.Pages.Value;
            bookModel.Description = bookViewModel.Description;
            bookModel.Publisher = new PublisherModel() { ID = int.Parse(bookViewModel.SelectedPublisher) };

            foreach (var authorID in bookViewModel.SelectedAuthors)
            {
                bookModel.Authors.Add(new AuthorModel() { ID = int.Parse(authorID) });
            }

            return bookModel;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookDetailsViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var bookModel = this.ConvertBookDetailsViewModelToBookModel(bookViewModel);

                BookBLL.Insert(bookModel);
                return RedirectToAction("Index");
            }

            bookViewModel.PublisherList = PublisherBLL.ListAll();
            bookViewModel.AuthorsList = AuthorBLL.ListAll();

            return View(bookViewModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BookModel book = BookBLL.FindBookById(id.Value);
            if (book == null)
            {
                return HttpNotFound();
            }

            var bookViewModel = new BookDetailsViewModel(book);

            bookViewModel.BookID = id.Value;
            bookViewModel.PublisherList = PublisherBLL.ListAll();
            bookViewModel.AuthorsList = AuthorBLL.ListAll();

            return View(bookViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookDetailsViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {
                var bookModel = this.ConvertBookDetailsViewModelToBookModel(bookViewModel);
                bookModel.ID = bookViewModel.BookID;

                BookBLL.Update(bookModel);
                return RedirectToAction("Index");
            }

            bookViewModel.PublisherList = PublisherBLL.ListAll();
            bookViewModel.AuthorsList = AuthorBLL.ListAll();

            return View(bookViewModel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookModel book = BookBLL.FindBookById(id.Value);
            if (book == null)
            {
                return HttpNotFound();
            }

            var bookViewModel = new BookDetailsViewModel(book);

            bookViewModel.BookID = id.Value;

            return View(bookViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookBLL.DeleteById(id);            
            return RedirectToAction("Index");
        }
    }
}