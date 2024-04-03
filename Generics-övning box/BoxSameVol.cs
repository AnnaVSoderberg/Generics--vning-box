using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_övning_box
{
    internal class BoxSameVol : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            if(x.length*x.hight*y.width == y.length * y.hight * y.width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }
}
