using Microsoft.AspNetCore.Mvc;
using Mission11_Anderson.Models;
using Mission11_Anderson.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Anderson.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepo _bookstoreRepo;

        public HomeController(IBookstoreRepo temp)
        {
           _bookstoreRepo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var bookView = new BooksListViewModel
            {
                Books = _bookstoreRepo.Books
                    .OrderBy(x => x.Title)
                    .Skip(pageSize * (pageNum - 1))
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookstoreRepo.Books.Count()
                }
            };

            return View(bookView);
        }
    }
}
