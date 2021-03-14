using System;

class MainClass {
   static void BubbleSort(int[] nummer) {
   bool Sorterar = true;
   for (int i = 0; i < nummer.Length - 1 && Sorterar; i++)
   {
     Sorterar = false;
      for (int j = 0; j < nummer.Length - 1 - i; j++)
      {
        if (nummer[j] > nummer[j + 1])
        {
          Sorterar = true;
          int a = nummer[j +1];
          nummer[j + 1] = nummer[j];
          nummer[j] = a;
         }
        }
      }
   }
   static int[] GenerateData(int size)
   {
    Random slump = new Random();
     int[] nummer = new int[size];
     for (int i = 0; i < nummer.Length; i++)
     nummer[i] = slump.Next(nummer.Length);
     return nummer;
     }
     static void Main(string[] args)
   {
     int[] sizes = new int[] { 10, 1000, 100000 };
     for (int i = 0; i < sizes.Length; i++)
    {
     Console.WriteLine("antalet är: " +  sizes[i]);
     int[] nummer  = GenerateData(sizes[i]);

     DateTime starta = DateTime.Now;
     BubbleSort(nummer);
     TimeSpan stannadtid = DateTime.Now - starta;
     Console.WriteLine("Tiden att sortera detta {0:0.00} ms ", stannadtid.TotalMilliseconds);
     }
   }
}  