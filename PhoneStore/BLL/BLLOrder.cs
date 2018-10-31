using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLOrder
    {
        public int Id { get; set; }
        public BLLPhone Phone { get; set; }
        public BLLUser User { get; set; }

    }
}
