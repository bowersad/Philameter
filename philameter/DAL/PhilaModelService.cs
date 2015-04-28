using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using philameter.DAL.Entities;
using philameter.DAL.Repositories;

namespace philameter.DAL
{
    public class PhilaModelService : IDisposable
    {
        private Repositories.BaseRepository<Stats> _stats;
        private Repositories.BaseRepository<Category> _categories;

        public Repositories.BaseRepository<Stats> Stats
        {
            get
            {
                if (_stats == null)
                {
                    _stats = new StatsRepository(new PhilaModel());
                }

                return _stats;
            }
        }

        public Repositories.BaseRepository<Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    _categories = new CategoryRepository(new PhilaModel());
                }

                return _categories;
            }
        }


        public void Dispose()
        {
            return;
        }
    }
}