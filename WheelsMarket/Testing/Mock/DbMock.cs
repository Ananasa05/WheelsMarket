using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;

namespace Testing.Mock
{
    public class DbMock
    {
        public static WheelsMarketDbContext Instance
        {
            get
            {
                var options = new DbContextOptionsBuilder<WheelsMarketDbContext>()
                    .UseInMemoryDatabase("WheelsMarketInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

                return new WheelsMarketDbContext(options, false);
            }
        }
    }
}
