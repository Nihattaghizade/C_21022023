
using System;
using System.Collections;
using System.Collections.Generic;

namespace _21022023home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arrlist = new ArrayList();
            arrlist.Add(8);
            arrlist.Add("Nihat");
            arrlist.Add('L');
            arrlist.Add(true);
            arrlist.Add(4.5);

            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }

            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); 
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var num = primeNumbers[1];

            SortedList<string, double> numbersName = new SortedList<string, double>();

            numbersName.Add("Bir", 1);
            numbersName.Add("Uc", 3);
            numbersName.Add("Bes", 5);
            numbersName.Add("Yeddi", 7);


            foreach (var item in numbersName)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine(numbersName["Uc"]);

            Dictionary<int, string> numbersName = new Dictionary<int, string>();

            numbersName.Add(1, "Bir");
            numbersName.Add(3, "Uc");
            numbersName.Add(5, "Bes");
            numbersName.Add(7, "Yeddi");

            int no;
            do
            {
                Console.WriteLine("Student no:");
                no = Convert.ToInt32(Console.ReadLine());
            } while (numbersName.ContainsKey(no));


            Console.WriteLine("numbersName:");
            string name = Console.ReadLine();


            numbersName.Add(no, name);

            foreach (var item in numbersName)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            Stack<int> mystack = new Stack<int>();

            mystack.Push(1);
            mystack.Push(3);
            mystack.Push(5);
            mystack.Push(7);


           foreach (var item in mystack)
           {
                Console.WriteLine(item);
           }

            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(3);
            callerIds.Enqueue(5);
            callerIds.Enqueue(7);

            foreach (var item in callerIds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
