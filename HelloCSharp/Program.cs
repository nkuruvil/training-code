using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Basic Calculator");

            var state = true;

            do
            {

                Console.WriteLine("Menu");
                System.Console.WriteLine("Press 1 for Addition");
                System.Console.WriteLine("Press 2 for Subtraction");
                System.Console.WriteLine("Press 3 for Multiplication");
                System.Console.WriteLine("Press 4 for Division");
                System.Console.WriteLine("Press 5 to exit");
                
                var choice = System.Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        //var input1 = (double)Console.ReadLine();//explicit casting with exception
                        //var input2 = Console.ReadLine() as double;//Exxplicit casting with null

                        var input1 = double.Parse(Console.ReadLine());//explicit parsing with 0
                        double input2;
                        double.TryParse(Console.ReadLine(), out input2);//explict parsing with exception


                        Add(input1, input2);
                        break;
                    case "2":

                        if(double.TryParse(Console.ReadLine(), out input1)){
                            System.Console.WriteLine("Valid");
                        } else {
                            System.Console.WriteLine("Not Valid");
                        }

                        if(double.TryParse(Console.ReadLine(), out input2)){
                            System.Console.WriteLine("Valid");
                        } else {
                            System.Console.WriteLine("Not Valid");
                        }

                        Subtract(input1, input2);

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        state = false;
                        break;
                }

            }while(state);

        }

        static void Add(double operand1, double operand2){
            var result = operand1 + operand2;
            System.Console.WriteLine($"Your answer is {result}");
        }

        static void Subtract(double operand1, double operand2){
            var result = operand1 - operand2;
            System.Console.WriteLine($"Your answer is {result}");
        }
        static void Multiplication(double operand1, double operand2){
            var result = operand1 * operand2;
            System.Console.WriteLine($"Your answer is {result}");
        }

        static void Division(double operand1, double operand2){
            var result = operand1 / operand2;
            System.Console.WriteLine($"Your answer is {result}");          
        }

    }
}