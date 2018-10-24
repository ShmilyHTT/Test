using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.DAL
{
    public class BaseDAL
    {
        protected DBContainer context;

        public BaseDAL()
        {
            context = new DBContainer();
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}
