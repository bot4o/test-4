using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IBookService
    {
       bool Add(Book model);
       bool Update(Book model);
       Book GetById(int id);
       bool Delete(int id);
       BookListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByBookId(int bookId);

    }
}
