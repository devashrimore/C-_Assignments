/*Create a class named Player that contains Player name, runs scored as data members.
 * Create a class named Team that contains an array of Player. Implement IEnumerable interface for class Team.
Write a console based application to create an object named India. 
Use foreach loop to iterate through the object India to display information about its players*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment5CF_Q6
{
    class Team
    {
    
        static void Main(string[] args)
        {

            Player[] india = new Player[]
            {
                new Player{Name="Rohit",Runs=25000},
                new Player{Name="Ajay",Runs=26700},
                new Player{Name="Virat",Runs=2600},
             };

            IEnumerable<Player> GetAllCustomer()
            {
                return india;
            }
            foreach (var item in GetAllCustomer())
            {
                Console.Write("\nName: " + item.Name + "\nRuns Scored :" + item.Runs);
            }

   }    }
}

