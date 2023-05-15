using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string methodName = "TupleWithValues";

        switch (methodName)
        {
            case "Tuplesix":
                Tuplesix();
                break;
            case "TupleParam":
                TupleParam();
                break;
            case "TupleWithValues":
                TupleWithValues();
                break;
            case "WithSortedList":
                WithSortedList();
                break;
            default:
                Console.WriteLine("Tundmatu meetod!");
                break;
        }
    }

    private static void TupleParam()
    {
        throw new NotImplementedException();
    }

    static void Tuplesix()
    {
        var values = (1, 2, 3, 4, 5, 6);
        TupleParam(values);
    }

    static void TupleParam((int, int, int, int, int, int) values)
    {
        Console.WriteLine($"TupleParam: {values.Item1}, {values.Item2}, {values.Item3}, {values.Item4}, {values.Item5}, {values.Item6}");
    }

    static void TupleWithValues()
    {
        var values = (42, "Hello", "World");
        Console.WriteLine($"TupleWithValues: {values.Item1}, {values.Item2}, {values.Item3}");
    }

    static void WithSortedList()
    {
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(4, "Four");
        sortedList.Add(2, "Two");
        sortedList.Add(5, "Five");
        sortedList.Add(1, "One");
        sortedList.Add(3, "Three");

        Console.WriteLine("WithSortedList:");
        foreach (var item in sortedList)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
