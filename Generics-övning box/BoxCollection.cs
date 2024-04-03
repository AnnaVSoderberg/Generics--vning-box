using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_övning_box
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> innerCollection;
        public BoxCollection()
        {
            innerCollection = new List<Box>();
        }
        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }


        public int Count 
        {
            get { return innerCollection.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("Box is already registered in collection");
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;

            foreach (Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
                
            }
            return found;
        }

        public bool Contains(Box item, EqualityComparer<Box> comp)
        {
            bool found = false;

            foreach (Box b1 in innerCollection)
            {
                if (b1.Equals(item))
                {
                    found = true;
                }

            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;

            for( int i = 0;i < innerCollection.Count; i++)   //VILKET HÅLL<>?? 
            {
                Box currentBox = innerCollection[i];

                if(new BoxSameDia().Equals(currentBox, item))
                {
                    innerCollection.RemoveAt(i);
                    result= true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
