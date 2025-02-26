using System;

class Program
{
    static void Main(string[] args)
    {
        int end = 0;
        bool quit = false;
        Console.Write("What is the Scripture reference without the scripture: ");
        string _reference = Console.ReadLine();
        Console.Write("Copy and paste the scripture you would like to memorize: ");
        string _scripture = Console.ReadLine();
        Scripture _1scripture = new Scripture(_reference, _scripture);
        while (quit != true || end != _1scripture.PEnd())
        {
            end = 0;
            end += _1scripture.AddInt();
            _1scripture.DisplayScripture();
            _1scripture.HideRandomWords();
            Console.WriteLine("1.1");
            Console.Write("\nTo end early type 'quit' here -> ");
            Console.WriteLine("1.2");
            string _repeat = Console.ReadLine();
            Console.WriteLine("1.3");
            if (_repeat == "quit")
            {
                quit = true;
                Console.WriteLine("2");
            }
            else if (_repeat == "")
            {
                Console.WriteLine("3");
            }
        }

    }
}
