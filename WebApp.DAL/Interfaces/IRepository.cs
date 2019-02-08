using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebApp.DAL.Interfaces
{
    public interface IRepository<T>where T : IEntity
    {
        IQueryable<T> GetAll();
        T GetByID(int id);
        void Create(T entity);
        void Update(T entity);
        void Delite(int id);
    }
}
