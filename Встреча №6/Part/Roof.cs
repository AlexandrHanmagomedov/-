using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Roof : IPart {
        public void build ( House house ) {
            house.roof = new Roof ( );
        }
    }
}
