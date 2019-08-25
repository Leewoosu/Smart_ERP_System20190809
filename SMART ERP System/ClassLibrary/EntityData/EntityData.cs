using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
                try
                {
                    entities.Set<T>().Add(entity);
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Exception raise = e;
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                   eve.Entry.Entity.ToString(),
                   ve.ErrorMessage);

                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }

        public void Update(T entity)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                try
                {
                    entities.Entry(entity).State = EntityState.Modified;
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Exception raise = e;
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                   eve.Entry.Entity.ToString(),
                   ve.ErrorMessage);

                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }

        public void Delete(T entity)
        {
            using (ERPEntities entities = new ERPEntities())
            {
                try
                {
                    entities.Entry(entity).State = EntityState.Deleted;
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    Exception raise = e;
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                   eve.Entry.Entity.ToString(),
                   ve.ErrorMessage);

                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
    }
}
