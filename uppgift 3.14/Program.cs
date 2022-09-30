using System;


namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("har du gått gymnaiset? svara med j för ja och n för nej");
            string rättsvar= Console.ReadLine();

            Console.WriteLine("Hur gammal är du");
            int ålder = int.Parse(Console.ReadLine());

            if (rättsvar == "j" && ålder < 22)
            {
                Console.WriteLine("vi vill gärna anställda dig");
            }
            else
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu ");
            







        }
    }
}