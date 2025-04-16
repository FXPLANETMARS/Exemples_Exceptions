using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple2
{
    internal class ExceptionEquation:Exception
    {
        public ExceptionEquation():base("Le discriminant est négatif, il n'y a pas de solution ") { }

        public ExceptionEquation(string message) : base(message) { }

    }
}
