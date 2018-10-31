using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    [ServiceContract]
    public interface ICRUD<T> where T:class 
    {
        [OperationContract]
        void Create(T x);
        [OperationContract]
        void Delete(T x);
        [OperationContract]
        void Update(T x);
        [OperationContract]
        IEnumerable<T> Get();
    }
}
