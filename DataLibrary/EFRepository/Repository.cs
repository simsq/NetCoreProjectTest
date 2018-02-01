using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLibrary.EFRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        #region Fields
        private readonly DbContext _dbContext;
        private DbSet<T> _entities;
        #endregion

        #region Ctor
        public Repository()
        {

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
            _dbContext.SaveChanges();

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
            _dbContext.SaveChanges();

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
            _entities.Add(entity);
            _dbContext.SaveChanges();

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
            _dbContext.SaveChanges();

        }

        public void Update(T tentity)
        {
            if (tentity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            //保存
            _dbContext.SaveChanges();
        }

        public void Update(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            _dbContext.SaveChanges();
        }

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _dbContext.Set<T>();
                }
                return _entities;
            }
        }

        #endregion


    }
}
