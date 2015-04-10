using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using philameter.DAL.Entities;
using philameter.DAL.Repositories;

namespace philameter.DAL
{
    public class PhilaModelService
    {
        private Repositories.BaseRepository<Stats> _stats;
        private Repositories.BaseRepository<Tags> _tags;
        private Repositories.BaseRepository<StatTags> _stattags;

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

        public Repositories.BaseRepository<Tags> Tags
        {
            get
            {
                if (_tags == null)
                {
                    _tags = new TagsRepository(new PhilaModel());
                }

                return _tags;
            }
        }

        public Repositories.BaseRepository<StatTags> StatTags
        {
            get
            {
                if (_stattags == null)
                {
                    _stattags = new StatsTagsRepository(new PhilaModel());
                }

                return _stattags;
            }
        }

    }
}