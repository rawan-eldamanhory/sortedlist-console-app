using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create sortedlist 
            SortedList<int, string> slist = new SortedList<int, string>();

            //adding elements in sortedlist
            slist.Add(3, "Three");
            slist.Add(1, "One");
            slist.Add(2, "Two");
            slist.Add(4, null);
            slist.Add(10, "Ten");
            slist.Add(5, "Five");

            //Accessing elements
            Console.WriteLine(slist[1]);      // One
            Console.WriteLine(slist[2]);      // Two
            Console.WriteLine(slist[3]);      // Three

            //display content
            foreach (var item in slist)
                Console.WriteLine(item);     // (1, "One") (2, "Two") (3, "Three") (4, null)
                                             // (5, "Five") (10, "Ten")

            //display content
            foreach (KeyValuePair<int, string> i in slist)
            {
                Console.WriteLine("Key: {0} Value: {1}", i.Key, i.Value); //key:1 value:One , key:2 value:Two   
            }                                                             //key:3 value:Three , key:4 value:
                                                                          //key:5 value:Five , key:10 value:Ten

            //remove elements
            slist.Remove(10);   // remove (10, "Ten")      // key
            slist.RemoveAt(0);   // remove (1, "One")      // index 

            foreach (var item in slist)
                Console.WriteLine(item); // (2, "Two") (3, "Three") (4, null) (5, "Five")

            //finding an element
            Console.WriteLine("The key 3 is present in SortedList: " + slist.ContainsKey(3)); //True
            Console.WriteLine("The key 9 is present in SortedList: " + slist.ContainsKey(9)); //False
            Console.WriteLine("The value Five is present in SortedList: " + slist.ContainsValue("Five")); //True
            Console.WriteLine("The value Six is present in SortedList: " + slist.ContainsValue("Six")); //False

            //get the maximum size of sortedlist
            Console.WriteLine("Capacity = " + slist.Capacity);  //8

            //count the number of elements in sortedlist 
            Console.WriteLine("Count = " + slist.Count);   //4

            SortedList myslist = new SortedList();
            myslist.Add("L001", "Elyse");
            myslist.Add("L002", "Meg");
            myslist.Add("L003", "Sarah");
            myslist.Add("L004", "Nicole");
            myslist.Add("L005", "Alyssa");
            myslist.Add("L006", "Megan");
            myslist.Add("L007", "Jess");
            myslist.Add("L008", "Belinda");

            //check whether sortedlist is fixedsize or not
            Console.WriteLine("Is Fixed Size ? : " + myslist.IsFixedSize);  //False

            //check whether sortedlist is readonly or not
            Console.WriteLine("Is Read Only ? : " + myslist.IsReadOnly);    //False


            Console.ReadKey();
        }
    }
    
}
