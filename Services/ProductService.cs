using System.Collections.Generic;
using repohelp.Models;
using repohelp.Repositories;

namespace repohelp.Services
{
    public class ProductService : IProductService
    {
        private readonly IBaseRepository<Product> _repository;

        public ProductService(IBaseRepository<Product> repository)
        {
            this._repository = repository;
        }
        public IEnumerable<Product> getAll()
        {
            return this._repository.getAll();
        }
    }
}