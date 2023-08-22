using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesProjectYF
{
    /// <summary>
    /// Class Sedan that implements the IAutomobile interface
    /// All properties of IAutomobile is attached with a private setter to the speed property
    /// a construtor for the class take a double parameter called speed
    /// wheels are set to 4, Speed to speed and LicensePlate to string
    /// a public void stringify contains a console.writeline 
    /// two implemented methods increase and decrease the speed of the sedan by 5 when called
    /// </summary>
    internal class Sedan : IAutomobile
    {
        public double Speed  { get; private set; }

        public int Wheels  { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {

            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";

        }
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}");


        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }


}
