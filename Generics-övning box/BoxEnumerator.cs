using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_övning_box
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection box;
        private int currentIndex;
        private Box currentBox;


        public BoxEnumerator(BoxCollection box)
        {
            this.box = box;
            this.currentIndex = -1;
            this.currentBox = default(Box);
        }


        public Box Current 
        { 
            get { return currentBox; }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (++currentIndex >= box.Count)
            {
                return false;
            }
            else
            {
                currentBox = box[currentIndex];
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
