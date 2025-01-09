using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<String> products = new List<String>();
            while (true)
            {
                Console.WriteLine("1.Enter Product. ");
                Console.WriteLine("2.Enter Product Details. ");
                Console.WriteLine("3.Delete Product.");
                Console.WriteLine("4.Update Products.");
                Console.WriteLine();
                Console.WriteLine("Select the action you want to perform:");
                Console.WriteLine() ;
                string process;
                process = Console.ReadLine();

                if (process != "1" && process != "2" && process != "3" && process != "4" )
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option! Please enter 1, 2, 3 or 4.");
                    Console.WriteLine();
                    continue; 
                }

                switch (process)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Enter Product: ");
                        products.Add(Console.ReadLine());
                        Console.WriteLine(); 
                        break;

                    case "2":
                        Console.WriteLine();
                        for (int i = 0; i < products.Count; i++)
                        {
                            Console.Write($"{i}.Product  {products[i]}");
                            Console.WriteLine();
                            
                        }
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine();
                        for (int i = 0; i < products.Count; i++)
                        {
                            
                            Console.Write($"{i}.Product  {products[i]}");
                            Console.WriteLine();

                        }
                        
                        Console.WriteLine();
                        Console.WriteLine("Enter product number for delete: ");
                        int index;
                        bool isValid = int.TryParse(Console.ReadLine(), out index);


                        if (isValid && index >= 0 && index < products.Count)
                        {
                            products.RemoveAt(index);
                            Console.WriteLine();
                            Console.WriteLine("Succesfully!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("İnvalid Option! Try Again.") ;
                            Console.WriteLine() ;
                        }
                        break;


                    case "4":
                        Console.WriteLine();
                        for (int i = 0; i < products.Count; i++)
                        {

                            Console.Write($"{i}.Product  {products[i]}");
                            Console.WriteLine();

                            
                        }
                        Console.WriteLine();
                        Console.WriteLine("Select Product for Update: ");
                        Console.WriteLine();

                        int indexUp;
                        bool isValid1 = int.TryParse(Console.ReadLine(), out indexUp);

                        if (isValid1 && indexUp >= 0 && indexUp < products.Count)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter New Product: ");
                            string newProductName=Console.ReadLine();
                            products[indexUp] = newProductName;
                            Console.WriteLine();
                            Console.WriteLine("Succesfully! New List Here: ");
                            Console.WriteLine();
                            for (int i = 0; i < products.Count; i++)
                            {

                                Console.Write($"{i}.Product  {products[i]}");
                                Console.WriteLine();

                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("İnvalid Option! Try Again.");
                            Console.WriteLine();
                        }


                        break;

                   




                }


                Console.ReadKey();



            }
         




        }
    }
}
