﻿namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatorler");

            //Atama ve Islemli Atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantiksal Operatorler

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            //Iliskisel Operatorler

            int a = 3;
            int b = 4;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            // Aritmetik Operatorler

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);



        }
    }
}