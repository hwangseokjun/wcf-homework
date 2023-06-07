using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public interface IRepository<T, ID> where T : class
    {
        ID Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        T FindById(ID id);
        IEnumerable<T> FindAll();
    }
}
