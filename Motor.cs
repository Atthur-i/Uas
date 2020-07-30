using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Uas
{
    public class Motor : Kendaraan
    {
        public double duit { get; set; }
        public override void Data()
        {
            Console.WriteLine();
        }
        internal override object Biaya()
        {
            return duit = Jam * 2000;
        }
    }
}
