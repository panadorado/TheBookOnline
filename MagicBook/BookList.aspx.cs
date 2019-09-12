using System;
using MagicBook.Models;
using System.Linq;
using System.Web.ModelBinding;

namespace MagicBook
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public IQueryable<Book> GetBooks([QueryString("id")] int? categoryId)
        {
            var _db = new MagicBook.Models.BookContext();
            IQueryable<Book> query = _db.Books;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}