using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_övning_box
{
    internal class BoxSameDia : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            if(x.length == y.length && x.width == y.width && x.hight == y.hight)
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
