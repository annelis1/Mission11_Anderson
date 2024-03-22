namespace Mission11_Anderson.Models
{
    public interface IBookstoreRepo
    {
        public IQueryable<Book> Books { get; }
    }
}
