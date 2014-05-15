using SocialEducation.DataModel.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace SocialEducation.DataModel
{
    /// <summary>
    /// A generic repository for working with data in the database
    /// </summary>
    /// <typeparam name="T">A POCO that represents an Entity Framework entity</typeparam>
    public class JustToExtendRepository<T> where T : class
    {
        /// <summaGetAllry>
        /// The context object for the database
        /// </summary>
        private static DbContext _context
        {
            get
            {
                return ContextFactory.Context;
            }
        }

        /// <summary>
        /// The IObjectSet that represents the current entity.
        /// </summary>
        private static DbSet<T> _objectSet
        {
            get
            {
                return _context.Set<T>();
            }
        }

        protected static DbSet<T> FetchAsSet()
        {
            return _objectSet;
        }

        /// <summary>
        /// Gets all records as an IQueryable
        /// </summary>
        /// <returns>An IQueryable object containing the results of the query</returns>
        public static IQueryable<T> Fetch()
        {
            return _context.Set<T>().AsNoTracking();
        }

        /// <summary>
        /// Gets all records as an IEnumberable
        /// </summary>
        /// <returns>An IEnumberable object containing the results of the query</returns>
        public static IEnumerable<T> GetAll()
        {
            return Fetch().AsEnumerable();
        }

        /// <summary>
        /// Finds a record with the specified criteria
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A collection containing the results of the query</returns>
        public static IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _objectSet.Where<T>(predicate);
        }



        /// <summary>
        /// Gets a single record by the specified criteria (usually the unique identifier)
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single record that matches the specified criteria</returns>
        public static T Single(Func<T, bool> predicate)
        {
            return _objectSet.Single<T>(predicate);
        }

        /// <summary>
        /// The first record matching the specified criteria
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        /// <returns>A single record containing the first record matching the specified criteria</returns>
        public static T First(Func<T, bool> predicate)
        {
            return _objectSet.First<T>(predicate);
        }

        /// <summary>
        /// Deletes the specified entitiy
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        /// <exception cref="ArgumentNullException"> if <paramref name="entity"/> is null</exception>
        public static void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _objectSet.Remove(entity);
        }

        /// <summary>
        /// Deletes records matching the specified criteria
        /// </summary>
        /// <param name="predicate">Criteria to match on</param>
        public static void Delete(Func<T, bool> predicate)
        {
            IEnumerable<T> records = from x in _objectSet.Where<T>(predicate) select x;
            foreach (T record in records)
            {
                _objectSet.Remove(record);
            }
        }

        /// <summary>
        /// Adds the specified entity
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <exception cref="ArgumentNullException"> if <paramref name="entity"/> is null</exception>
        private static void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _objectSet.Add(entity);
        }

        /// <summary>
        /// Attaches the specified entity
        /// </summary>
        /// <param name="entity">Entity to attach</param>
        private static void Attach(T entity)
        {
            _objectSet.Attach(entity);
            _context.Entry(entity).State = System.Data.EntityState.Modified;
        }

        /// <summary>
        /// Saves all context changes
        /// </summary>
        public static void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    System.Diagnostics.Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                       eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static T PrepareToSave(T entity)
        {
            //Create clean context for saving
            ContextFactory.RefreshContextIfNotRefreshed();

            //Set Base Fields
            DateTime now = DateTime.Now;
            entity.GetType().GetProperty("UpdateDate").SetValue(entity, now, null);
            entity.GetType().GetProperty("CreateDate").SetValue(entity, now, null);
           // entity.GetType().GetProperty("UpdateUsername").SetValue(entity, username, null);
            int objectId = (int)entity.GetType().GetProperty("Id").GetValue(entity, null);

            //Clean connected Objects
            foreach (var MethodInfo in entity.GetType().GetMethods())
            {
                if (MethodInfo.Name.StartsWith("set_") && MethodInfo.IsVirtual)
                    MethodInfo.Invoke(entity, new Object[] { null });
            }

            //Decide to Add or Attach
            if (objectId <= 0)
            {
                //entity.GetType().GetProperty("CreateDate").SetValue(entity, now, null);
                //entity.GetType().GetProperty("CreateUsername").SetValue(entity, username, null);
                Add(entity);
            }
            else
            {
                var attachedEntity = _context.Set<T>().Find(objectId);
                if (attachedEntity != null)
                {
                    //Update if already attached
                    var attachedObject = ((UzaktanEgitimEntities)_context).Entry(attachedEntity);
                    attachedObject.CurrentValues.SetValues(entity);
                    attachedObject.State = System.Data.EntityState.Modified;
                }
                else
                {
                    //Attach if not attached yet
                    Attach(entity);
                }
            }
            return entity;
        }

        public static T retrieveById(long Id)
        {
            return _objectSet.Find(Id);
        }

    }

}
