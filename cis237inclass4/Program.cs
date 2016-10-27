using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkedList myLinkedList = new IntegerLinkedList();
            myLinkedList.Display();
            myLinkedList.AddToFront(5);
            myLinkedList.AddToFront(4);
            myLinkedList.AddToFront(3);
            myLinkedList.AddToBack(6);
            myLinkedList.AddToBack(7);
            myLinkedList.AddToBack(8);
            myLinkedList.Display();

            //****************************************
            //Here is a generic linked list that tores strings
            IGenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<String>();


            //Here is a generic linked list tat stores any class the implements the IComparable interface
            IGenericLinkedList<IComparable> myComparablelinkedList = new GenericLinkedList<IComparable>();

            //Let's use the string one
            myGenericLinkedList.AddToBack("Foo");
            myGenericLinkedList.AddToBack("bar");
            myGenericLinkedList.AddToBack("Dave");
            myGenericLinkedList.AddToBack("Barnes");

            myGenericLinkedList.AddToBack("Back 4");
            myGenericLinkedList.AddToBack("Back 3");
            myGenericLinkedList.AddToBack("Back 2");
            myGenericLinkedList.AddToBack("Back 1");

            myGenericLinkedList.Display();

            string frontGuy = myGenericLinkedList.RemoveFromFront();

            Console.WriteLine(frontGuy);

            myGenericLinkedList.Display();

        }
    }
}
