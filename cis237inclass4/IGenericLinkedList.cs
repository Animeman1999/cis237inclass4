using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{

    //This linked list takes in the TYPE called T.
    //It is declared in the <> portion.
    //The name can be anything. We choose T, but it
    //can easily be FOO, or BAR or whatever you want. Standard for C# is "T"
    //You can even do multiple ones that look lik this:
    //IGenericeLinkedList<T1,T2>
    interface IGenericLinkedList<T>
    {
        //Since the type we want has come into this interface as 
        //Type T, we will use T as the type for the Data.
        //This means that if this linked list is declared with a string
        //passed in to T, this list will hold strings. If double is sent to T
        //it will hold doules, and so on.
        void AddToFront(T GenericData);
        void AddToBack(T GenericData);
        T RemoveFromFront();
        T RemoveFromBack();
        void Display();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
