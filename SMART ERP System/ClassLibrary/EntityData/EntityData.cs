using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.EntityData
{
    public class EntityData<T> where T : class
    {
        public List<T> GetAll()
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.Set<T>().Count();
            }
        }

        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                return entities.Set<T>().Select(selector).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                entities.Set<T>().Add(entity);
                entities.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                entities.Entry(entity).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                entities.Entry(entity).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }
    }
}
