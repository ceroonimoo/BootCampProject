using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        T GetById(int id);
        List<T>  GetAll();
        T Add(T entity);
        T Update(T entity);
        T Delete(int id);

    }
}
