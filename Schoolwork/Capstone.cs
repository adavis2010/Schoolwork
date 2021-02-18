using System;
using System.Collections.Generic;
using System.Text;

namespace Schoolwork {
    class Capstone : Iprintable {
        //specifying class implements interface

        public DateTime CertificationDate { get; set; }
        public int Attempts { get; set;}
        public int Score { get; set; }

        //print method for Capstone () = No parameters
        public void Print() {

            var msg = $"CAPSTONE:score:{Score}, on attempt{Attempts} {CertificationDate}";
            Console.WriteLine(msg);

        }
        //must put GetScore in every class that uses the added interface method
        public int GetScore() {
            return Score;
        }





    }


}
