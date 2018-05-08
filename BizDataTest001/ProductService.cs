using BizDataLibrary;
using BizDataLibrary.Models;
using BizDataLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDataTest001
{
    public class ProductService
    {
        public void Create(Product entity)
        {
            BizModel content = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(content);
            repository.Create(entity);
            content.SaveChanges();
        }
        public List<Product> GetAll() {
            BizModel content = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(content);
            var result = repository.GetAll().OrderBy((x) => x.PartNo).ToList();
            return result;
        }
        public Product GetByPartNo(string partNo)
        {
            BizModel context = new BizModel();
            BizRepository<Product> repository = new BizRepository<Product>(context);
            var result = repository.GetAll().FirstOrDefault((x) => x.PartNo == partNo);
            return result;
        }
     }
}
