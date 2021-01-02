using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class MyCollection<T> : IEnumerable<T>
    {
        List<T> _customType = new List<T>();

        public void AddToMyCollection(T item)
        {
            _customType.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _customType)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int TotalItemCount { get { return _customType.Count; } }

        
    }
}
