using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_övning_box
{
    internal class Box : IEquatable<Box>
    {

        public int hight {  get; set; }
        public int length { get; set; }
        public int width { get; set; }

        public Box( int h, int l, int w) 
        {
            this.hight = h;
            this.length = l;
            this.width = w;
        
        }
        public bool Equals(Box? other)
        {
            if (new BoxSameDia().Equals(this, other))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
