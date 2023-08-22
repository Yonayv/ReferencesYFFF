using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesProjectYF
{
    internal class Program
        
    {
        /// <summary>
        /// Sedan is a new object
        /// IAutomobile is declared and assigned to sedan object
        /// another new sedan object has the same speed as the first sedan object
        /// SpeedUp on the first sedan is created
        /// Speed of the sedan & Iautomobile object are printed
        /// Iautomobile and the first sedan are compared to each other
        /// SpeedUp on the second sedan object is called
        /// the sedan objects are compared to each other and results printed to console
        /// a truck object is created 
        /// the stringify method on all the objects are called on by using an Iautomobile and foreach loop
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);

            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));


            Truck myTruck = new Truck(50, 500, "MyTruck");

            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();    
            





        }

    }
}
