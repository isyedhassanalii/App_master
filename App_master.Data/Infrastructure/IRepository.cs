using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Data.Infrastructure
{
   public interface IRepository<T> where T:class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      
        T GetById(string id);
        
        IEnumerable<T> GetAll();
    }
}
