﻿//using System;

//using System.Text;

//using System.Collections.Generic;

//public class Program

//{
//    public static void Main()

//    {

//        string[] words =

//            { "the", "fox", "jumps", "over", "the", "dog" };

//        LinkedList<string> sentence = new LinkedList<string>(words);

//        Display(sentence, "The linked list values:");

//        Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
//            sentence.Contains("jumps"));

//        sentence.AddFirst("today");

//        Display(sentence, "Test 1: Add 'today' to beginning of the list:");


//        LinkedListNode<string> mark1 = sentence.First;

//        sentence.RemoveFirst();

//        sentence.AddLast(mark1);

//        Display(sentence, "Test 2: Move first node to be last node:");


//        sentence.RemoveLast();

//        sentence.AddLast("yesterday");

//        Display(sentence, "Test 3: Change the last node to 'yesterday':");

//        mark1 = sentence.Last;

//        sentence.RemoveLast();

//        sentence.AddFirst(mark1);

//        Display(sentence, "Test 4: Move last node to be first node:");


//        sentence.RemoveFirst();

//        LinkedListNode<string> current = sentence.FindLast("the");

//        IndicateNode(current, "Test 5: Indicate last occurence of 'the':");


//        sentence.AddAfter(current, "old");

//        sentence.AddAfter(current, "lazy");

//        IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");


//        current = sentence.Find("fox");

//        IndicateNode(current, "Test 7: Indicate the 'fox' node:");


//        sentence.AddBefore(current, "quick");

//        sentence.AddBefore(current, "brown");

//        IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox':");


//        mark1 = current;

//        LinkedListNode<string> mark2 = current.Previous;

//        current = sentence.Find("dog");

//        IndicateNode(current, "Test 9: Indicate the 'dog' node:");

//        Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list:");

//        try

//        {
//
//            sentence.AddBefore(current, mark1);
//
//        }

//        catch (InvalidOperationException ex)
//
//        {

//            Console.WriteLine("Exception message: {0}", ex.Message);
//
//        }

//        Console.WriteLine();



//        sentence.Remove(mark1);

//        sentence.AddBefore(current, mark1);

//        IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog):");


//        sentence.Remove(current);

//        IndicateNode(current, "Test 12: Remove current node (dog) and attempt to indicate it:");


//        sentence.AddAfter(mark2, current);

//        IndicateNode(current, "Test 13: Add node removed in test 11 after a referenced node (brown):");


//        sentence.Remove("old");

//        Display(sentence, "Test 14: Remove node that has the value 'old':");


//        sentence.RemoveLast();

//        ICollection<string> icoll = sentence;

//        icoll.Add("rhinoceros");

//        Display(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");

//        Console.WriteLine("Test 16: Copy the list to an array:");

//        string[] sArray = new string[sentence.Count];

//        sentence.CopyTo(sArray, 0);

//        foreach (string s in sArray)
//
//        {

//            Console.WriteLine(s);
//
//       }

//        sentence.Clear();

//        Console.WriteLine();

//        Console.WriteLine("Test 17: Clear linked list. Contains 'jumps' = {0}",
//            sentence.Contains("jumps"));

//        Console.ReadLine();
//
//    }

//    private static void Display(LinkedList<string> words, string test)
//
//    {

//        Console.WriteLine(test);

//        foreach (string word in words)
//
//        {

//            Console.Write(word + " ");
//
//        }

//        Console.WriteLine();

//        Console.WriteLine();
//
//    }

//    private static void IndicateNode(LinkedListNode<string> node, string test)
//
//    {
//        Console.WriteLine(test);

//        if (node.List == null)
//
//        {

//            Console.WriteLine("Node '{0}' is not in the list.\n",
//                node.Value);

//            return;
//
//        }

//        StringBuilder result = new StringBuilder("(" + node.Value + ")");

//        LinkedListNode<string> nodeP = node.Previous;

//        while (nodeP != null)
//
//        {

//            result.Insert(0, nodeP.Value + " ");

//            nodeP = nodeP.Previous;
//
//        }

//        node = node.Next;

//        while (node != null)
//
//        {

//            result.Append(" " + node.Value);

//            node = node.Next;
//
//        }

//        Console.WriteLine(result);

//        Console.WriteLine();
//
//    }
//
//}


