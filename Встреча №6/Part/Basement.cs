using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Basement : IPart {
        public void build ( House house ) {
            house.basement=new Basement ();
        }
    }
}
