using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class House  {

        public Basement basement;
        public List<Walls> walls;
        public List<Window> windows;
        public Door door;
        public Roof roof;


        public void print (TeamLeader teamLeader ) {
            if ( teamLeader.report.Count == 11 ) {
                Console.WriteLine ("House is well done(END) \n\t__/\\__\n\t|    |\n\t------");
            }
            else Console.WriteLine ( "House is Medium rare(NOT END)" );
        }



    }
}
