using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALOrder
    {
        public int Id { get; set; }
        public DALPhone Phone { get; set; }
        public DALUser User { get; set; }
    }
}
