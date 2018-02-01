using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace DataLibrary.EFRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        #region Fields

        private readonly EFProjectContext _efProjectContext;
        private DbSet<T> _entities;

        public Repository(EFProjectContext efProjectContext)
        {
            _efProjectContext = efProjectContext;
        }
        #endregion

        #region Util
        protected string GetFullError()
        {
            return "";
        }

        #endregion

        #region Methos

        /// <summary>
        /// 获取Table
        /// </summary>
        public IQueryable<T> Tabel => _entities;

        /// <summary>
        /// 获取Table 不跟踪
        /// </summary>
        public IQueryable<T> TableNoTracking => _entities.AsNoTracking();

        /// <summary>
        /// 删除一个对象
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            _entities.Remove(entity);
            _efProjectContext.SaveChanges();

        }

        public void Delete(IEnumerable<T> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");

            }
            foreach (var item in entity)
            {
                _entities.Remove(item);
            }
            _efProjectContext.SaveChanges();

        }

        public T GetById(object id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id is null");
            }
            return _entities.Find(id);
        }

        public void Insert(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            _efProjectContext.Add(entity);
            _efProjectContext.SaveChanges();
            //_entities.Add(entity);
            //_efProjectContext.SaveChanges();

        }

        public void Insert(IEnumerable<T> enumerable)
        {
           
            if (enumerable == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            foreach (var item in enumerable)
            {
                _entities.Add(item);
            }
            _efProjectContext.SaveChanges();

        }

        public void Update(T tentity)
        {
            if (tentity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            //保存
            _efProjectContext.SaveChanges();
        }

        public void Update(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            _efProjectContext.SaveChanges();
        }

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _efProjectContext.Set<T>();
                }
                return _entities;
            }
        }

        #endregion


    }
}
