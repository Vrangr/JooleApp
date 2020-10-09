using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleApp.Domain;
using JooleApp.Repositories.Repository;

namespace JooleApp.Repositories.Repository
{


    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly JooleAppEntities _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(JooleAppEntities context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetbyId(int Id)
        {
            return entities.SingleOrDefault(a => a.Id == Id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            //entities.AddOrUpdate(entity);

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();

        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }


        public void Save()
        {
            _context.SaveChanges();
        }


        
    }
}
