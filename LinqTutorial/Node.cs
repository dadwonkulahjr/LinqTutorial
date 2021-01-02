using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Node<T>
    {
        T _genericType;
        public T MyGenericProperty { get; set; }
       
        public Node(T genericType)
        {
            MyGenericProperty = genericType;
        }
        public T SetGenericType(T type)
        {
            _genericType = type;
            return _genericType;
        }
    }


    
}
