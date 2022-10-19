using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Team : IWorker {
        public string Name {get => "We need to build a ziggurat";}
        public TeamLeader teamLeader;
        public List<Worker> workers;

        public Team ( ) {
            teamLeader = new TeamLeader ( "Bugor" );
            workers = new List<Worker> ( ) { new Worker ("Biba"), new Worker ("Boba"),
                                            new Worker ( "Wolk"), new Worker ( "Zayac") };


        }
    }
}
