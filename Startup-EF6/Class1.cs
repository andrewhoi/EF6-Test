using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Startup_EF6.DbContext;
using Xunit;

namespace Startup_EF6
{
    public class Class1
    {
        [Fact]
        public void OpenContext()
        {
            using (var dbContext = new NorthwindContext())
            {

            }
        }
    }
}
