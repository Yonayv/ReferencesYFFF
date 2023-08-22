using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesProjectYF
{
    /// <summary>
    /// This truck class implements the IAutomobile interface
    /// All the properties of IAutomobile interface is attached with a private setter to the speed property
    /// An additional double property weight has a automatic getter
    /// a construtor for the class takes three parameters, a double speed, a double weight & a string LicenseNum
    /// the speed is set to speed, weight to weight, & LicenseNum inside the construtor.
    /// the weight < 400, and wheels set to 8 and and else set to 12
    /// a public void stringify method has a console.writelind printed
    /// the two implemented methods increase/decrease of the trucks speed is 5
    /// </summary>
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        public Truck(double speedParam, double weigtParam, string LicenseNum)
        {
            Speed = speedParam;
            Weight = weigtParam;
            LicensePlate = LicenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}");
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
