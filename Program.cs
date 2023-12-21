namespace ConsoleApp5._1._2_3
{
    internal class Program
    {
        static string ShowColor(string name, int age)
        {
            Console.WriteLine("{0}, {1}\n Напишите свой любимый цвет на английском с маленькой буквы", name, age);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static void ShowColors(params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }


        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            ShowColors(favcolors[0], favcolors[2]);   // вывод первого и третьего элементов массива цветов


            //Console.WriteLine("Ваши любимые цвета:");
           // foreach (var color in favcolors)
           //{
           //     Console.WriteLine(color);

           // }
            //Console.WriteLine("Первый и последний элемент массива ваших любимы цветов:");
            //Console.WriteLine(favcolors[0]);
            //Console.WriteLine(favcolors[2]);



            Console.ReadKey();

        }
    }
}