using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BLL.Contracts;
using DAL;

namespace BLL.Realization
{
    public class TradingService : ITrading
    {


        public BLLOrder Buy(BLLUser user, BLLPhone product)
        {
            Repository<DALUser> Repository = new Repository<DALUser>(new Context());
            Repository.Create(new DALUser { Adress = user.Email,Id = user.Id,Name = user.Name} );


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
