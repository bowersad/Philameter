using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using philameter.DAL;
using philameter.DAL.Entities;

namespace philameter.DAL.Repositories
{
    public class TagsRepository : BaseRepository<Tags>
    {
        public TagsRepository(PhilaModel context) : base(context) { }
    }
}