
namespace Mission11_Anderson.Models
{
    public class EFBookstoreRepo : IBookstoreRepo
    {
        private BookstoreContext _context;
        public EFBookstoreRepo(BookstoreContext temp) 
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
