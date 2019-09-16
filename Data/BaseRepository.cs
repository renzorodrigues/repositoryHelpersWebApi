using System.Collections.Generic;
using repohelp.Models;
using repohelp.Repositories;
using RepositoryHelpers.DataBaseRepository;

namespace repohelp.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : IEntity {
        private readonly CustomRepository<T> Repository;

        public BaseRepository () {
            Repository = new CustomRepository<T> (ConnectionBuilder.Instance.Connection);
        }

        public IEnumerable<T> getAll () {
            return Repository.Get ();
        }
    }
}