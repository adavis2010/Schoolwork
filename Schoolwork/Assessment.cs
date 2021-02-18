using System;
using System.Collections.Generic;
using System.Text;

namespace Schoolwork {
    //specifying class implements interface

    class Assessment : Iprintable {
        // methods 
        public string Topic { get; set; }
        public DateTime DateOfAssessement { get; set; } = DateTime.Now;
        public int Score { get; set; }
        public int MaxScore { get; set; }
        //note: cannot have instance methods in interface (these 4 above that start with public)

        //print method for Assessment () = No parameters
        public void Print() {

            var msg = $"ASSESSMENT:score:{Score}, topic{Topic} {DateOfAssessement}";
            Console.WriteLine(msg);

        }
        //must put GetScore in every class that uses the added interface method
        public int GetScore() {
            return Score;
        }




    }
}
