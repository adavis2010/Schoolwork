using System;

namespace Schoolwork {
    class Program {
        static void Main(string[] args) {
           
            // create array for Assessment scores and Capstone
            var jadaCapstone = new Capstone {
                Attempts = 1, CertificationDate = new DateTime(2020, 8, 15), Score = 100
            };

            var jadaGit = new Assessment {
                Topic = "Git", DateOfAssessement = new DateTime(2020, 6, 15), Score = 120
            };

            var jadaSql = new Assessment {
                Topic = "SQL", DateOfAssessement = new DateTime(2020, 7, 5), Score = 110
            };

            // add new + interface name and []
            var jada = new Iprintable[] { jadaCapstone, jadaGit, jadaSql };
            //use foreach loop
            foreach (var item in jada) {
                //all we have to do is call print since we have the Interface and it made 
                //assesment and capstone have something in common
                item.Print();
            }
     
      
     
        
        }
    }
}
