using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Vector[] array = new Vector[3]
        {
            new Vector("Red", 3, 4),
            new Vector("Green", 1, 1),
            new Vector("Blue", 6, 8)
        };

        Console.WriteLine("First massive before:");
        foreach (var v in array)
        {
            if (v != null)
            {
                v.PrintInfo();
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        Vector? foundInArray = Array.Find(array, v => v.LineColor == "Green"); //finding element

        array[0].Increase(1, 1); //renewing element

        array[1] = null!; //removing element

        Console.WriteLine("First massive after:");

        foreach (var v in array)
        {
            if (v != null)
            {
                v.PrintInfo();
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        Console.WriteLine("\n---------------------------------------------------------------");
        ArrayList arrayList = new ArrayList();

        arrayList.Add(new Vector("Red", 3, 4));
        arrayList.Add(new Vector("Green", 1, 1));
        arrayList.Add(new Vector("Blue", 6, 8));

        Console.WriteLine("ArrayList before:");
        foreach (object item in arrayList)
        {
            Vector v = (Vector)item;
            v.PrintInfo();
        }

        Vector? foundInArrayList = null;    //finding
        foreach (object item in arrayList)
        {
            Vector v = (Vector)item;
            if (v.LineColor == "Blue")
            {
                foundInArrayList = v;
                break;
            }
        }

        ((Vector)arrayList[0]!).LineColor = "Yellow";   //renewing


        if (foundInArrayList != null) arrayList.Remove(foundInArrayList);   //removing

        Console.WriteLine("ArrayList after:");
        foreach (object item in arrayList)
        {
            Vector v = (Vector)item;
            v.PrintInfo();
        }


        Console.WriteLine("\n---------------------------------------------------------------");
        List<Vector> list = new List<Vector>
        {
            new Vector("Red", 3, 4),
            new Vector("Green", 1, 1),
            new Vector("Blue", 6, 8)
        };

        Console.WriteLine("List<Vector> before:");
        foreach (var v in list) v.PrintInfo();

        Vector? foundInList = list.Find(v => v.GetLength() > 5);    //finding

        list[1].Increase(4, 3);     //renewing


        list.RemoveAt(0);   //removing

        Console.WriteLine("List<Vector> after:");
        foreach (var v in list) v.PrintInfo();
    }
}