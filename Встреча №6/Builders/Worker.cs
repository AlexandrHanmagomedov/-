using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Worker : IWorker {

        string Name { get; set; }
        string IWorker.Name => Name;

        public Worker ( string name ) { Name = name; }

        public void Construction ( House house, TeamLeader teamLeader ) {

            if ( house.basement == null ) {
                Basement basement = new Basement ( );
                basement.build ( house );
                teamLeader.report.Add ( $"Worker {Name} build is basement" );
            }
            else if ( house.door == null) {
                Door door = new Door ( );
                door.build ( house );
                teamLeader.report.Add ( $"Worker {Name} build is door" );
            }
            else if ( house.roof == null ) {
                Roof roof = new Roof ( );
                roof.build ( house );
                teamLeader.report.Add ( $"Worker {Name} build is roof" );

            }
            else if (house.walls == null || house.walls.Count < 4 ) {
                if (house.walls == null){
                    house.walls = new List<Walls>();
                }
                Walls walls = new Walls ( );
                walls.build ( house );
                teamLeader.report.Add ( $"Worker {Name} build is wall {house.walls.Count}" );
            }
            else if (house.windows == null || house.windows.Count<4) {
                if (house.windows == null){
                    house.windows = new List<Window>();
                }
                Window windows = new Window ( );
                windows.build ( house );
                teamLeader.report.Add ( $"Worker {Name} build is windows {house.windows.Count}" );
            }





        }
    }
}
