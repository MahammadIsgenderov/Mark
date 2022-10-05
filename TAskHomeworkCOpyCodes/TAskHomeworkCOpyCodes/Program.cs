using System;

namespace TAskHomeworkCOpyCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {15,16,25,41,75,84};
            EdediOrta(array);
        }
       //static void Hello(string soz,int a)
       // {
       //     Console.WriteLine(soz+" "+a+" "+"yashindadir");
       // }
       static void EdediOrta(int[] coxluq)
        {
            int cem = 0;
            foreach (var item in coxluq)
            {
                cem=cem+item;
             }
            double ededlerincemi=cem;
            Console.WriteLine(cem);
            double b = ededlerincemi / coxluq.Length;
            Console.WriteLine(b);
        }
    }
}
