using System.Collections.Generic;
using repohelp.Models;

namespace repohelp.Services
{
    public interface IProductService
    {
         IEnumerable<Product> getAll();
    }
}