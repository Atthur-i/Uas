using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Uas
{
    public abstract class Kendaraan
    {
        public string NoKen { get; set; }
        public double Jam { get; set; }
        public virtual void Data()
        {
            Console.WriteLine();
        }
        internal abstract object Biaya();

    }
}
