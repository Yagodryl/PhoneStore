using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class BLLOrder
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public BLLPhone Phone { get; set; }
        [DataMember]
        public BLLUser User { get; set; }

    }
}
