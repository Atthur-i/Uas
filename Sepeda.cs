using System;
using System.Collections.Generic;
using System.Text;

namespace Uas
{
    public class Sepeda : Kendaraan
    {
        
        public double duit { get; set; }
        public override void Data()
        {
            Console.WriteLine();
        }

        internal override object Biaya()
        {
            return duit = 1000;
        
    }
}
}
