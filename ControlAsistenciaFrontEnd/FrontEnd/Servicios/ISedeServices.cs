using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FrontEnd.Models;

namespace FrontEnd.Servicios
{
   public  interface ISedeServices
    {
        void Insert(Sede t);
        void Update(Sede t);
        void Delete(Sede t);
        IEnumerable<Sede> GetAll();
        Sede GetOneById(int id);
        Task<IEnumerable<Sede>> GetAllAsync();
        Task<Sede> GetOneByIdAsync(int id);
    }
}
