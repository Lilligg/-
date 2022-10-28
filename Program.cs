namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор"); 
            while (true)
            {
                Console.WriteLine("Введите 1 число:");
                int one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите действие из предложенных: +, -, *, /");
                string go = Console.ReadLine();
                Console.WriteLine("Введите 2 число:");
                int two = Convert.ToInt32(Console.ReadLine());
                
                string plus = "+";
                string minus = "-";
                string delenie = "/";
                string ymnojenie = "*";


                if (go == plus)
                {
                    Console.WriteLine(one + two);
                }
                else if (go == minus)
                {
                    Console.WriteLine(one - two);
                }
                else if (go == delenie)
                {
                    if (two == 0)
                    {
                        Console.WriteLine("Ошибка, на ноль делить нельзя");
                    }
                    else
                    {
                        Console.WriteLine(one / two);
                    }
                }
                else if (go == ymnojenie)
                {
                    Console.WriteLine(one * two);
                }
                else
                {
                    Console.WriteLine("Ошибка в определении действия, попробуйте еще раз");
                }
                Console.WriteLine("________________________________________________");
                }
            }
        }
	}
  
