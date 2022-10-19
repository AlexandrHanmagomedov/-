using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Встреча__6 {
    internal class Program {
        static void Main ( string[] args ) {
            House house = new House ( );
            Team team = new Team();
            Console.WriteLine ( team.Name);

            team.teamLeader.Report ( );
            Console.WriteLine();
            Random r = new Random ( );

            team.workers[1].Construction(house,team.teamLeader);
            team.workers[0].Construction(house, team.teamLeader);
            team.workers[3].Construction(house, team.teamLeader);
            team.workers[2].Construction(house, team.teamLeader);

            team.teamLeader.Report();

            foreach (var a in team.teamLeader.report)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nsmoke break\n");

            team.workers[1].Construction(house, team.teamLeader);
            team.workers[0].Construction(house, team.teamLeader);
            team.workers[3].Construction(house, team.teamLeader);
            team.workers[2].Construction(house, team.teamLeader);

            foreach (var a in team.teamLeader.report)
            {
                Console.WriteLine(a);
            }

            team.teamLeader.Report();

            team.workers[2].Construction(house, team.teamLeader);
            team.workers[2].Construction(house, team.teamLeader);
            team.workers[2].Construction(house, team.teamLeader);

            foreach (var a in team.teamLeader.report)
            {
                Console.WriteLine(a);
            }

            team.teamLeader.Report();

        

            house.print ( team.teamLeader );

        }
    }
}
