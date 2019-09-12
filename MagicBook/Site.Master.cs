using System;
using System.Collections.Generic;
using MagicBook.Models;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MagicBook
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new MagicBook.Models.BookContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}