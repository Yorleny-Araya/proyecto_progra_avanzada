using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
   public interface IAutenticacionServices
    {
        void Insert(Autenticacion t);
        void Update(Autenticacion t);
        void Delete(Autenticacion t);
        IEnumerable<Autenticacion> GetAll();
        Autenticacion GetOneById(int id);
        Task<IEnumerable<Autenticacion>> GetAllAsync();
        Task<Autenticacion> GetOneByIdAsync(int id);
    }
}
