
namespace MyFirstProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
            // switch = an efficient alternative to many else if statements


            String name = "";

                while (name == "")
            {
                Console.Write("What is your name?");
                name = Console.ReadLine();
            }
                
                Console.WriteLine("Hello " + name);

                Console.ReadKey();
            }
        }
    }





  
