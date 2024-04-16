using System;
using System.Net;
using System.Net.Mail;
class Program
{
   
    static void Main()
    {
        int[] myNumbers = new int[3];
        
        for(int i =0; i< 3; i++)
        {
            myNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(myNumbers);
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);
        }
    }
   
}
