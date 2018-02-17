using System;

namespace ConsoleApp1
{
    class AddSub
    {
        
        int x, y;
        int z;
        public AddSub(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public int Addition()
        {
            z = x + y;
            return z;
        }

        public int Subtraction()
        {
            z = x - y;
            return z;
        }
        public int Multiplication()
        {
            z = x * y;
            return z;
        }
        public class Arithmetcs
        {
            /*string FirstValue;
            string SecondValue;
            string Option;
            public Arithmetcs(string Options, string FirstValue, string SecondValue)
            {
                this.FirstValue = FirstValue;
                this.SecondValue = SecondValue;
                this.Option = Options;
            }*/

            public string Operations()
            {
                Console.WriteLine("Which operation do you want to perform" +
                " \nEnter 1 for addition,2 for Subtraction, 3 for Multiplication ");
                string Option = Console.ReadLine();

                Console.Write("Enter value for X: ");
                string FirstValue = Console.ReadLine();

                Console.Write("Enter value for Y: ");
                string SecondValue = Console.ReadLine();

                AddSub addsub = null;
                string message = null;
                string ErrorMessage = "Null or Non-numeric values not allowed";


                try
                {
                    addsub = new AddSub(Int32.Parse(FirstValue), Int32.Parse(SecondValue));
                }
                catch (Exception)
                {

                }
                if (Option == "1")
                {

                    try
                    {
                        Console.WriteLine("Addition of " + FirstValue + " and " + SecondValue + " is " + addsub.Addition());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(ErrorMessage);
                        //Console.Read();

                    }


                }
                else if (Option == "2")
                {
                    try
                    {
                        Console.WriteLine("Subtraction of " + FirstValue + " and " + SecondValue + " is " + addsub.Subtraction());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(ErrorMessage);
                        //Console.Read();

                    }
                }
                else if (Option == "3")
                {
                    try
                    {
                        Console.WriteLine("Multiplication of " + FirstValue + " and " + SecondValue + " is " + addsub.Multiplication());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(ErrorMessage);
                    }
                }


                else
                {
                    Console.WriteLine("please select correct operation options");


                }


                Console.Write("Do you wanna perform another operation? \nEnter Y or N: ");
                string ReOption = Console.ReadLine();
                if (ReOption.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                    message = "true";
                else if (ReOption.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                {
                    message = "false";
                    Console.Write("Exiting application.....");
                }

                else
                {
                    Console.WriteLine("Invalid Entry.\nExiting application...");
                    message = "false";
                }

                return message;

            }
            public void recursion(string message)
            {
                while (message == "true")
                {
                    Console.Clear();
                    message = Operations();


                }

            }
        }
        static void Main(string[] args)
        {

            Arithmetcs arithmetcs = new Arithmetcs();
            arithmetcs.recursion(arithmetcs.Operations());

            Console.Read();

        }

    }

}
