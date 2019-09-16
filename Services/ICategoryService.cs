using System.Collections.Generic;
using repohelp.Models;

namespace repohelp.Services
{
    public interface ICategoryService
    {
         IEnumerable<Category> getAll();
    }
}