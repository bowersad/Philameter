using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using philameter.DAL;
using philameter.DAL.Entities;

namespace philameter.DAL.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(PhilaModel _context) : base(_context) { }
    }
}