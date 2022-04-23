﻿using BE.DAL.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;
using BE.DAL.Repository;
using BE.DAL.EF;

namespace BE.DAL
{
    public class Asistencia : ICRUD<data.Asistencia>
    {

        private RepositoryAsistencia repo;
        public Asistencia(NDbContext dbContext)
        {
            repo = new RepositoryAsistencia(dbContext);
        }
        public void Delete(data.Asistencia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Asistencia> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Asistencia>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Asistencia GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Asistencia> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Asistencia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Asistencia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
