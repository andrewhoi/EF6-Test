using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Startup_EF6.DbContext;

using Xunit;



namespace Startup_EF6
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        [Fact]
        public void OpenContext()
        {
            using (var dbContext = new NorthwindContext())
            {

            }
        }
    }
}
