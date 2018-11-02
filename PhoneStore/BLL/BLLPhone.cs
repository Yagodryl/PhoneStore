using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [DataContract]
    public class BLLPhone
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Creator { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}
