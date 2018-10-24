using System.Linq;
using Test.Model;

namespace Test.IDAL
{
    public interface ISysSampleDAL
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        IQueryable<test_sys_sample> GetList();

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">数据库上下文</param>
        /// <returns>执行返回结果影响行数</returns>
        int Create(test_sys_sample entity);

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>执行返回结果影响行数</returns>
        int Delete(long id);

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">数据库上下文</param>
        /// <returns>执行返回结果影响行数</returns>
        int Edit(test_sys_sample entity);

        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        test_sys_sample GetById(long id);

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>返回结果</returns>
        bool IsExist(long id);

    }
}
