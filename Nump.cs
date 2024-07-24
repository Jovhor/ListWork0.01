using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWork0._01
{
    class Nump
    {
        public int NumpID { get; set; }

        public int NumpIS { get; set; }

        public override string ToString()
        {
            return "ID: " + NumpID + "  Число: " + NumpIS;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Nump objAsPart = obj as Nump;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return NumpID;
        }
        public bool Equals(Nump other)
        {
            if (other == null) return false;
            return (this.NumpID.Equals(other.NumpID));
        }
    }
}
