using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
   public class UIOrder
    {
        public int Id { get; set; }
        public UIPhone Phone { get; set; }
        public UIUser User { get; set; }

    }
}
