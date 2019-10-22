using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

    }

    internal class LinkList
    {
        public void Push(int value)
        {
            Size++;
            var node = new Node() { Value = value };
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Current.Next = node;
            }
            Current = node;

        }


        public void ListNodes()
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.Next;
            }
        }

        public int this[int position]
        {
            get
            {
                Node tempNode = Head;
                for (int i = 0; i < position; ++i)
                    // переходим к следующему узлу списка
                    tempNode = tempNode.Next;
                return tempNode.Value;
            }
        }
        private Node Head { get; set; }
        private Node Tails { get; set; }
        private Node Current { get; set; }
        private Node Current1 { get; set; }
        public int Size { get; set; }

        public static LinkList operator +(LinkList list1, LinkList list2)
        {

            var list = new LinkList();
            var size = list1.Size + list2.Size;
            list.Size = size;
            for (int i = 0; i < size; i++)
            {
                if (i < list1.Size)
                {
                    list.Push(list1[i]);
                }
                else
                {

                    list.Push(list2[i - list1.Size]);
                }

            }
            return list;

        }




        public static LinkList operator !(LinkList list)
        {


            LinkList link = new LinkList();

            for (int i = 0; i < list.Size; i++)
            {


                link.Push(list[list.Size - i - 1]);

            }

            return link;
        }

        public static LinkList operator <(LinkList list1, LinkList list2)
        {

            for (int i = 0; i < list2.Size; i++)
            {
                list1.Push(list2[i]);

            }
            return list1;

        }
        public static LinkList operator >(LinkList list1, LinkList list2)
        {
            for (int i = 0; i < list1.Size; i++)
            {
                list2.Push(list1[i]);

            }
            return list2;

        }


        public static bool operator ==(LinkList list1, LinkList list2)
        {
            if (list1.Size == list2.Size && list1.Equals(list2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(LinkList list1, LinkList list2)
        {


            if (list1.Size != list2.Size && !list1.Equals(list2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public class Owner
        {
            public int iD { get; set; }
            public string Name { get; set; }
            public string Organization { get; set; }

        }

        public class Date
        {
            public string date { get; set; }
        }

        public static LinkList operator ++(LinkList obj)
        {
            obj.Push(5);
            return obj;
        }


    }

}

        

 

    




