using System.Collections.Generic;
using repohelp.Models;
using repohelp.Repositories;

namespace repohelp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _repository;
        public CategoryService (IBaseRepository<Category> repository)
        {
            this._repository = repository;
        }
        public IEnumerable<Category> getAll()
        {
            return this._repository.getAll();
        }
    }
}