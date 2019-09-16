using System.Collections.Generic;
using repohelp.Data;
using repohelp.Models;
using RepositoryHelpers.DataBaseRepository;

namespace repohelp.Repositories {
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