using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Create(T t);

        void Remove(T t);

        void Update(T t);

        List<T> GetAll();

        T GetById(int id);
        
    }
}
