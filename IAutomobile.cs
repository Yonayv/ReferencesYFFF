using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesProjectYF
{
    internal interface IAutomobile
    {
        /// <summary>
        /// Interface IAutomobile
        /// A public double speed property with a automatic getter attached
        /// a public Int property with a automatic getter attached
        /// a public string LicensePlate with a automatic getter attaced
        /// Then a defined void method stringify
        /// </summary>

        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify(); 


    }

}
