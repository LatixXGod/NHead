using System.Collections.Generic;
using System.Collections;
using ConsoleApp3;
using System;



namespace SimpleAlgorithmsApp
{
    class programm {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            linkedList.Add("Bob"); //Добавление
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.Remove("Bill"); //Удаление
        }



    }
    
}        
        
    
    