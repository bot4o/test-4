using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Models.DTO;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Repositories.Implementation
{
    public class BookService : IBookService
    {
        private readonly DatabaseContext ctx;
        public BookService(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Add(Book model)
        {
            try
            {
                
                ctx.Book.Add(model);
                ctx.SaveChanges();
                foreach (int genreId in model.Genres)
                {
                    var bookGenre = new BookGenre
                    {
                        BookId = model.Id,
                        GenreId = genreId
                    };
                    ctx.BookGenre.Add(bookGenre);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.GetById(id);
                if (data == null)
                    return false;
                var bookGenres= ctx.BookGenre.Where(a => a.BookId == data.Id);
                foreach(var bookGenre in bookGenres)
                {
                    ctx.BookGenre.Remove(bookGenre);
                }
                ctx.Book.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Book GetById(int id)
        {
            return ctx.Book.Find(id);
        }

        public BookListVm List(string term="",bool paging=false, int currentPage=0)
        {
            var data = new BookListVm();
           
            var list = ctx.Book.ToList();
           
           
            if (!string.IsNullOrEmpty(term))
            {
                term = term.ToLower();
                list = list.Where(a => a.Title.ToLower().StartsWith(term)).ToList();
            }

            if (paging)
            {
                // here we will apply paging
                int pageSize = 5;
                int count = list.Count;
                int TotalPages = (int)Math.Ceiling(count / (double)pageSize);
                list = list.Skip((currentPage - 1)*pageSize).Take(pageSize).ToList();
                data.PageSize = pageSize;
                data.CurrentPage = currentPage;
                data.TotalPages = TotalPages;
            }

            foreach (var book in list)
            {
                var genres = (from genre in ctx.Genre
                              join mg in ctx.BookGenre
                              on genre.Id equals mg.GenreId
                              where mg.BookId == book.Id
                              select genre.GenreName
                              ).ToList();
                var genreNames = string.Join(',', genres);
                book.GenreNames = genreNames;
            }
            data.BookList = list.AsQueryable();
            return data;
        }

        public bool Update(Book model)
        {
            try
            {
                // these genreIds are not selected by users and still present is bookGenre table corresponding to
                // this bookId. So these ids should be removed.
                var genresToDeleted = ctx.BookGenre.Where(a => a.BookId == model.Id && !model.Genres.Contains(a.GenreId)).ToList();
                foreach(var bGenre in genresToDeleted)
                {
                    ctx.BookGenre.Remove(bGenre);
                }
                foreach (int genId in model.Genres)
                {
                    var bookGenre = ctx.BookGenre.FirstOrDefault(a => a.BookId == model.Id && a.GenreId == genId);
                    if (bookGenre == null)
                    {
                        bookGenre = new BookGenre { GenreId = genId, BookId = model.Id };
                        ctx.BookGenre.Add(bookGenre);
                    }
                }

                ctx.Book.Update(model);
                // we have to add these genre ids in bookGenre table
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<int> GetGenreByBookId(int bookId)
        {
            var genreIds = ctx.BookGenre.Where(a => a.BookId == bookId).Select(a => a.GenreId).ToList();
            return genreIds;
        }
       
    }
}
