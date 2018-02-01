using System.Collections.Generic;
using System.Linq;

namespace DataLibrary.EFRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// 根据ID获取单个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(object id);

        /// <summary>
        /// 添加单个对象
        /// </summary>
        /// <param name="t"></param>
        void Insert(T entity);

        /// <summary>
        /// 插入多个对象
        /// </summary>
        /// <param name="enumerable"></param>
        void Insert(IEnumerable<T> enumerable);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="tentity"></param>
        void Update(T tentity);

        /// <summary>
        /// 修改多个实体对象
        /// </summary>
        /// <param name="enumerable"></param>
        void Update(IEnumerable<T> enumerable);

        /// <summary>
        /// 删除单个
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 删除多个
        /// </summary>
        /// <param name="entity"></param>
        void Delete(IEnumerable<T> entity);

        /// <summary>
        /// 查询返回列表
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Tabel { get; }

        /// <summary>
        /// 查询返回列表 (不跟踪)
        /// </summary>
        IQueryable<T> TableNoTracking { get; }
    }
}
