using BizDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BizDataLibrary.Repository
{
    public class BizRepository<T> where T :class
    {
        
        private BizModel _context;

        //protected BizModel Context { get { return _context; } }

        public BizRepository(BizModel context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

        }
        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        
        //public abstract IQueryable<T> GetAll();

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }
        
    }
}
