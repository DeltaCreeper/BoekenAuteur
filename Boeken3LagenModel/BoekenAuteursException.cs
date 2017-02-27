using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenAuteurs3LagenModel
{
    public class BoekenAuteursException : ApplicationException
    {
        public BoekenAuteursException(string message) 
            : base(message)
        {

        }
    }
}
