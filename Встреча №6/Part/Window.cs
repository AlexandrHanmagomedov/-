using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Window : IPart {
        public void build ( House house ) {
            house.windows.Add ( new Window ( ) );
        }
    }
}
