using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.IBLL;
using Test.Model;
using Test.IDAL;

namespace Test.BLL
{
    public class SysSampleBLL: ISysSampleBLL
    {
        DBContainer db = new DBContainer();

        private ISysSampleDAL _iSysSampleDAL;
        public SysSampleBLL(ISysSampleDAL iSysSampleDAL)
        {
            _iSysSampleDAL = iSysSampleDAL;
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        public List<test_sys_sample> GetList()
        {
            IQueryable<test_sys_sample> queryData = _iSysSampleDAL.GetList();
            return queryData.ToList();
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Create(test_sys_sample entity)
        {
            try
            {
                if (_iSysSampleDAL.Create(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }

        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">id</param>
        /// <returns>是否成功</returns>
        public bool Delete(long id)
        {
            try
            {
                if (_iSysSampleDAL.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        public bool Edit(test_sys_sample entity)
        {
            try
            {
                if (_iSysSampleDAL.Edit(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHander.WriteException(ex);
                return false;
            }
        }

        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        public bool IsExists(long id)
        {
            if (db.test_sys_sample.SingleOrDefault(a => a.Id == id) != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 根据ID获得一个实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public test_sys_sample GetById(long id)
        {
            if (IsExist(id))
            {
                test_sys_sample entity = _iSysSampleDAL.GetById(id);
                return entity;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(long id)
        {
            return _iSysSampleDAL.IsExist(id);
        }
    }
}
