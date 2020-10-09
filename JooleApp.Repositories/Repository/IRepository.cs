using JooleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleApp.Repositories.Repository
{
   public  interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T GetbyId(int Id);

        void Insert(T entity);

        void Update(T entity);
        void Delete(T entity); // will delete from Database

        void Remove(T entity); // will not delete from Database

        void Save();
    }
}
