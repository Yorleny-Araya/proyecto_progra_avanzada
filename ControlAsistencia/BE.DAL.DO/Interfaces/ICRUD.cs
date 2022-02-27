using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BE.DAL.DO.Interfaces
{
    public interface ICRUD<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        IEnumerable<T> getAll();
        T getOneById(int id);
        Task<IEnumerable<T>> getAllAsync();
        Task<T> getOneByIdAsync(int id);

    }
}
