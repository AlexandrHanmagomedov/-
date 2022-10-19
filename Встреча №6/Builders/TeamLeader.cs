using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class TeamLeader : IWorker {

        string Name { get; set; }

        string IWorker.Name=>Name;

        public TeamLeader(string name) {Name = name;}
        
        public List<string>report=new List<string>();
            public void Report ( ) {
            //float f = (float)( report.Count / 11.0 ) * 100;
            double d = ( report.Count / 11.0 )*100 ;
            Console.WriteLine ( $"{d} % readiness of the house" );


        }

    }
}
