class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ваше имя: "); // Пользователь вводит свое имя
        string name = Console.ReadLine();

        Console.WriteLine("Hello world from " + name); // Выводим сообщение с именем пользователя

        Console.ReadKey();
    }
}