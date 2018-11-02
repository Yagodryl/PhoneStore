using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    [ServiceContract]
    public interface ITrading
    {
        [OperationContract]
        BLLOrder Buy(BLLUser user,BLLPhone product);
        [OperationContract]
        void Delete(BLLOrder order);
        IEnumerable<BLLOrder> GetAllOrders();
        [OperationContract]
        BLLOrder GetOrder(BLLUser user);
    }
}
