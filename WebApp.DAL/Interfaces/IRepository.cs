using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DAL.Interfaces
{
    public interface IRepository<T>where T : IEntity
    {
       // IQueryable<T> GetAll(); //-?
        IEnumerable<T> GetAll(Func<T, bool> filter = null);
        T GetByID(int id);
        void Create(T entity);
        void Update(T entity);
        void Delite(int id);
        
	/*
		T GetByID(object id);
		void Add(T entity);
		void Delete(object id);
		void Delete(T entity);
		void Update(T entityToUpdate);
        */
    }
}
