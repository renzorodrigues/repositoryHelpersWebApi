using System.Collections.Generic;
using repohelp.Models;

namespace repohelp.Repositories
{
    public interface IBaseRepository<T> where T : IEntity
    {
         IEnumerable<T> getAll();
    }
}