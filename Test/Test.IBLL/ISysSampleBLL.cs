using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.IBLL
{
    public interface ISysSampleBLL
    {
        List<test_sys_sample> GetList();
        bool Create(test_sys_sample entity);

        bool Delete(long id);

        bool Edit(test_sys_sample entity);

        bool IsExists(long id);

        test_sys_sample GetById(long id);

        bool IsExist(long id);

    }
}
