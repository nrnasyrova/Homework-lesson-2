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

            Console.WriteLine($"A: {A} B: {B}");

            //2nd assignment
            var operand1 = 6;
            var operand2 = 0;
            Console.Write("Sign: ");
            string sign = Console.ReadLine();

            double result = sign switch {
                "-" => operand1 - operand2,
                "+" => operand1 + operand2,
                "*" => operand1 * operand2,
                "/" => operand2 == 0 ? double.NaN : operand1 / operand2,
                _   => 0
            };

            if (double.IsNaN(result))
            {
                Console.WriteLine($"Нельзя делить на ноль"); 
            }
            else
            {
                Console.WriteLine($"Результат операции: {result}");
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

            int tempA = a;
            if (a <= b && a <= c)
            {
                a = Math.Max(b, c);
            }

            int tempC = c;
            c = Math.Min(b, Math.Min(tempA, c));

            if (b >= a)
            {
                Math.Max(tempA, tempC);
            }

            Console.WriteLine($"{a} , {b} , {c}");
        }
    }
}
