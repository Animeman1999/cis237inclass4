using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class IntegerLinkedList : IIntegerLinkedList
    {
        protected class Node
            //This is an "inner class" It will serv as our Node class for the linked list
            //Because it si an inner class, it canpt be used outside this class, which 
            //is okay since we don't need it anywhere but int here
        {
            //Node has 2 properties. Dat, to store the data
            //and next to point to the next node in the list.
            public int Data { get; set; }
            public Node Next { get; set; }
        }

        //Head and Tail to point to the beginning and end of the linked list noeds
        protected Node _head;
        protected Node _tail;
        protected int _size; 

        //Check to see if the head is null.  If the head pointer is null, there is nothing in the list
        public bool IsEmpty
        {
            get
            {
                return (_head == null);
            }
        }

        //Get the size by returning the backing field's value.
        public int Size
        {
            get
            {
                return _size;
            }
        }
        public void AddToFront(int IntegerData)
        {
            //Make a new pointer named oldHead that points to the same plase as 
            //the head variable points to.
            Node oldHead = _head;
            //Create a new nod and store it in the head variable
            _head = new Node();
            //Set the data on the new node
            _head.Data = IntegerData;
            //set the next property to the old head
            _head.Next = oldHead;
            //Increase the size 
            _size++;
            //If the size is equal to one, which means, one node only
            //the head and the tail are the same, so let's set them that way
            if (_size == 1)
            {
                _tail = _head;
            }
        }

        public void AddToBack(int IntegerData)
        {
            //Create a new node that points to the same loatioin as the tail
            Node oldTail = _tail;
            //Create a new node and store in it the tail variable
            _tail = new Node();
            //Set the data
            _tail.Data = IntegerData;
            //Set the next to null since this is the last node
            _tail.Next = null;

            //We can check to see if the list is empty.  Empty is the head point to null
            //Since on an initial add ading  to the tail, head is still null. We want head and tail
            //to point to the same first node.
            //Therfore if the list is empty, just se the head equal to the tail.
            if (IsEmpty)
            {
                _head = _tail;
            }
            else
            {
                //Otherwise, this is not an initial add. It is with an established list
                //so we just need to set the oldTails's next pointer to the new tail we created
                oldTail.Next = _tail;
            }

            //Increse the size of the lsit
            _size++;

        }

        public int RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            //get out the data that needs to be returned
            int returnData = _head.Data;

            //Move the head to the next node in the list
            //Luckily head knows where the next node is by it's next Porperty
            _head = _head.Next;

            //**Now that there are no variables that point to where the old head is
            //the garbage collector can come clean u p that ode for us.

            //Decrement the size
            _size++;

            //Check to see if we just removed the last node in the list
            //if so, we want to set tail to null as well.
            if (IsEmpty)
            {
                _tail = null;
            }

            //Return the data
            return returnData;
        }

        //Tis one takes more work than the other 3. **********************Keep this in mind for assighnemnt **************************
        public int RemoveFromBack()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            //Get the data from the tail node. This is what we will return
            int returnData = _tail.Data;

            //If we are in the situation where there is only one node left, and 
            //that is the one I want to remove, I need to set both head and tail
            //to null. That way there are no references to the last node, and the 
            //garbage collector will pic it up.
            if(_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                //Create a current node and start it at head. Just like in the display method.
                //This way we can 'walk' the list
                Node current = _head;

                //While currents next property is not equal to the tail.
                //Which means, while wer are not at the node right before the tail
                while(current.Next != _tail)
                {
                    current = current.Next;
                }

                //When we get there we will set the tail to the current node;
                _tail = current;

                _tail.Next = null;
            }


            //Return the return data
            return returnData;
        }

        public void Display()
        {
            if (IsEmpty)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.WriteLine("This list is:");
                //Defin a node that starts point at the same place as head;
                Node current = _head;
                //While the current pointer is not null (null would suggest that it is now
                //pointing at a location that is past the end of the list. (or the end of the list)
                while (current != null)
                {
                    //Write out the data
                    Console.Write(current.Data + ", ");
                    //Move the current pointer to the next node in the list
                    //We can accomplish this by taking the pointer that is in
                    //The current node's next property,a nd assigning it to the
                    //current variable
                    current = current.Next;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        //Constructor
        //Initialize all of the variables to the default values
        public IntegerLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;

        }
    }
}
