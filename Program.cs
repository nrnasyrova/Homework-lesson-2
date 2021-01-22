using System;

namespace HomeworkLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st assignment
            Console.Write("A: ");
            int.TryParse(Console.ReadLine(), out int A);
            Console.Write("B: ");
            int.TryParse(Console.ReadLine(), out int B);

            if (A > B)
            {
                B = A;
            }
            else if (B > A)
            {
                A = B;
            }
            else
            {
                A = 0;
                B = 0;
            }

            Console.WriteLine($"A: {A}");
            Console.WriteLine($"B: {B}");

            //2nd assignment
            var operand1 = 6;
            var operand2 = 2;
            Console.Write("Sign: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "-":
                Console.WriteLine(operand1 - operand2);
                break;

                case "+":
                Console.WriteLine(operand1 + operand2);
                break;

                case "*":
                Console.WriteLine(operand1 * operand2);
                break;

                case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine("Нельзя делить на 0");
                    break;
                }
                else
                {
                    Console.WriteLine(operand1 / operand2);
                }
                break;
            }

            //3rd assignment
            Console.Write("Number: ");
            var isParsed = int.TryParse(Console.ReadLine(), out int number);

            if (!isParsed)
            {
                Console.WriteLine("Нужно ввести число");
            }
            else if (number >= 0 && number <= 14)
            {
                Console.WriteLine("Ваше число входит в промежуток [0 - 14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("Ваше число входит в промежуток [15 - 35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine("Ваше число входит в промежуток [36 - 50]");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine("Ваше число входит в промежуток [51 - 100]");
            }
            else
            {
                Console.WriteLine("Ваше число не входит ни в один промежуток");
            }
            
            //4th assignment
            Console.Write("Price: ");
            var priceParsed = double.TryParse(Console.ReadLine(), out double price);
            
            if (price > 500 && price < 100)
            {
                price = price - (price * 0.03);
            }
            else if (price > 1000)
            {
                price = price - (price * 0.05);
            }
            
            Console.WriteLine($"Цена с учетом скидки: {price}");

            //5th assignment
            Console.Write("1st: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("2nd: ");
            int.TryParse(Console.ReadLine(), out int number2);
            Console.Write("3rd: ");
            int.TryParse(Console.ReadLine(), out int number3);
            Console.Write("4th: ");
            int.TryParse(Console.ReadLine(), out int number4);

            if (number1 >= number2 || number2 >= number3 || number3 >= number4)
            {
                Console.WriteLine(Math.Min(number1, Math.Min(number2, Math.Min(number3,number4))));
            }
            else if (number1 == number2 && number2 == number3 && number3 == number4)
            {
                Console.WriteLine(number1 * number2 * number3 * number4);
            }
            else
            {
                Console.WriteLine("Числа расположены по возрастанию");
            }
            //была сложность с нахождением метода, который выведет минимальное число

            //6th assignment
            Console.Write("a: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b: ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.Write("c: ");
            int.TryParse(Console.ReadLine(), out int c);

            var aSwapped = a;
            var bSwapped = b;
            int cSwapped = c;

            if (c >= b && c >= a && b >= a)
            {
                aSwapped = c;
                cSwapped = a;
                Console.WriteLine($"Числа: {aSwapped}, {bSwapped}, {cSwapped}");
            }
            else if (c >= b && c >= a && b <= a)
            {
                aSwapped = c;
                bSwapped = a;
                cSwapped = b;
                Console.WriteLine($"Числа: {aSwapped}, {bSwapped}, {cSwapped}");
            }
            else if (b >= c && b >= a && c >= a)
            {
                aSwapped = b;
                bSwapped = c;
                cSwapped = a;
                Console.WriteLine($"Числа: {aSwapped}, {bSwapped}, {cSwapped}");
            }
            else if (b >= c && b >= a && c <= a)
            {
                aSwapped = b;
                bSwapped = a;
                Console.WriteLine($"Числа: {aSwapped}, {bSwapped}, {cSwapped}");
            }   
            else if (a >= c && a >= b && b <= c)
            {
                bSwapped = c;
                cSwapped = b;
                Console.WriteLine($"Числа: {a}, {b}, {c}");
            }   
            else
            {
                Console.WriteLine($"Числа: {a}, {b}, {c}");
            }   
        }
    }
}
