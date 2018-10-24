using System;
using System.Linq;
using Test.IDAL;
using Test.Model;
using System.Data;
using System.Collections.Generic;

namespace Test.DAL
{
    public class SysSampleDAL : ISysSampleDAL, IDisposable
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<test_sys_sample> GetList()
        {
            using (DBContainer db = new DBContainer())
            {
                IQueryable<test_sys_sample> list = db.test_sys_sample.AsQueryable();
                return list;
            }
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">数据库上下文</param>
        /// <returns>执行返回结果影响行数</returns>
        public int Create(test_sys_sample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<test_sys_sample>().Add(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>执行返回结果影响行数</returns>
        public int Delete(long id)
        {
            using (DBContainer db = new DBContainer())
            {
                test_sys_sample entity = db.test_sys_sample.SingleOrDefault(a => a.Id == id);
                db.Set<test_sys_sample>().Remove(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="entity">数据库上下文</param>
        /// <returns>执行返回结果影响行数</returns>
        public int Edit(test_sys_sample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<test_sys_sample>().Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }



        /// <summary>
        /// 获取一个实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public test_sys_sample GetById(long id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.test_sys_sample.SingleOrDefault(a => a.Id == id);
            }
        }

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>返回结果</returns>
        public bool IsExist(long id)
        {
            using (DBContainer db = new DBContainer())
            {
                test_sys_sample entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
