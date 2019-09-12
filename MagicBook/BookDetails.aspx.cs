using System;
using MagicBook.Models;
using System.Linq;
using System.Web.ModelBinding;

namespace MagicBook
{
    public partial class BookDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Book> GetDetails([QueryString("bookID")] int? bookId)
        {
            var _db = new MagicBook.Models.BookContext();
            IQueryable<Book> query = _db.Books;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.BookID == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}