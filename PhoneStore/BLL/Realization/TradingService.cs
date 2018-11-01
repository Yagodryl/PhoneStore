using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Contracts;
namespace BLL.Realization
{
    public class TradingService : ITrading
    {
        public BLLOrder Buy(BLLUser user, BLLPhone product)
        {

            return null;
        }

        public void Delete(BLLOrder order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BLLOrder> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public BLLOrder GetOrder(BLLUser user)
        {
            throw new NotImplementedException();
        }
    }
}
