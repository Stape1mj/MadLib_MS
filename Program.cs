using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Mad Lib. Please give your input to the following:");
           
            Console.WriteLine("adjective");
            string adj = Console.ReadLine();
           
            Console.WriteLine("noun");
            string n = Console.ReadLine();
            
            Console.WriteLine("verb(past tense)");
            string vpt = Console.ReadLine();
            
            Console.WriteLine("adverb");
            string adv = Console.ReadLine();
            
            Console.WriteLine("adjective");
            string adj2 = Console.ReadLine();
            
            Console.WriteLine("noun");
            string n2 = Console.ReadLine();
            
            Console.WriteLine("noun");
            string n3 = Console.ReadLine();
            
            Console.WriteLine("adjective");
            string adj3 = Console.ReadLine();
            
            Console.WriteLine("verb");
            string v = Console.ReadLine();
            
            Console.WriteLine("adverb");
            string adv2 = Console.ReadLine();
            
            Console.WriteLine("verb(past tense)");
            string vpt2 = Console.ReadLine();

            Console.WriteLine("adjective");
            string adj4 = Console.ReadLine();

            Console.WriteLine("Thank you for your compliance. I will now generate a Mad Lib");

            Console.ReadLine();

            Console.WriteLine($"Today I went to the zoo. I saw a {adj} {n} jumping up and down in its tree. He {vpt} {adv} " +
                $"through the large tunnel that led to its {adj2} {n2}. I got some peanuts and passed them through the cage" +
                $" to a gigantic gray {n3} towering above my head. Feeding that animal made me hungry. I went to get a {adj3}" +
                $" scoop of ice cream. It filled my stomach. Afterwards I had to {v} {adv2} to catch our bus. When I got home I" +
                $" {vpt2} my mom for a {adj4} day at the zoo" );

            Console.ReadLine();
        
        }
        }
}
