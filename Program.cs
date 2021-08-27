using System;

namespace Lesson8
{
     class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = new string[] { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine( "Исходный массив:" );
            foreach (string s in arr) { Console.Write( s + " " ); }
            Console.WriteLine( $"\nПоследний элемент: {0}", ArrayHelper.Pop(ref arr) );
            Console.WriteLine( "Новый массив:" );
            foreach ( string s in arr ) { Console.Write( s + " " ); }
            System.Console.WriteLine("\n");
            
            Console.WriteLine( "Исходный массив:" );
            foreach (string s in arr) { Console.Write( s + " " ); }
            Console.Write( "\nДобавить элемент: " );
            string ne = Console.ReadLine();
            Console.WriteLine( "Новая длина массива: {0}", ArrayHelper.Push( ref arr, ne ) );
            System.Console.WriteLine("\n");

           
            Console.WriteLine( "Исходный массив:" );
            foreach (string s in arr) { Console.Write( s + " " ); }
            Console.WriteLine( $"\nПоследний элемент: {0}", ArrayHelper.Shift(ref arr) );
            Console.WriteLine( "Новый массив:" );
            foreach ( string s in arr ) { Console.Write( s + " " ); }
            System.Console.WriteLine("\n");
            
            Console.WriteLine( "Исходный массив:" );
            foreach (string s in arr) { Console.Write( s + " " ); }
            Console.Write( "\nДобавить элемент: " );
            string be = Console.ReadLine();
            Console.WriteLine( "Новая длина массива: {0}", ArrayHelper.UnShift( ref arr, ne ) );
        }
    public static class ArrayHelper
{
    public static string Pop(ref string[] sourceArray)
    {
        string lastElement = sourceArray[sourceArray.Length - 1];
 
        string[] newArr = new string[sourceArray.Length - 1];
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = sourceArray[i];
        }
 
        sourceArray = newArr;
        return lastElement;
    }
 
    public static int Push(ref string[] sourceArray, string value)
    {
        string[] newArray = new string[sourceArray.Length + 1];
 
        for (int i = 0; i < sourceArray.Length; i++)
        {
            newArray[i] = sourceArray[i];
        }
 
        newArray[newArray.Length - 1] = value;
 
        sourceArray = newArray;
        return sourceArray.Length;
    }
 
    public static string Shift(ref string[] sourceArray)
    {
        string firstElement = sourceArray[0];
 
        string[] newArray = new string[sourceArray.Length - 1];
 
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = sourceArray[i + 1];
        }
 
        sourceArray = newArray;
        return firstElement;
    }
 
    public static int UnShift(ref string[] sourceArray, string value)
    {
        string[] newArray = new string[sourceArray.Length + 1];
        newArray[0] = value;
 
        for (int i = 0; i < sourceArray.Length; i++)
        {
            newArray[i + 1] = sourceArray[i];
        }
 
        sourceArray = newArray;
        return sourceArray.Length;
    }
  }
 }
}

