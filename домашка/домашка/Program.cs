using System;

namespace domashka
{
    class Program
    {
        static int i = 0;
        static char[] arr = new char[5];
        static void Main(string[] args)
        {
            int k = 0;
            int v = arr.Length - 1;
            while (arr[v] == 0)
            {
                char s = Console.ReadKey().KeyChar;
                AddChar(s);
            }
            foreach (var item in arr)
                Console.WriteLine(item);
        }
        static void AddChar(char s)
        {
            int pause = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                while (arr[k] == s && pause == 0)
                {
                    Console.WriteLine(" буква уже есть в массиве");
                    pause++;
                }
            }
            if (pause == 0)
            {
                Console.WriteLine(" добавляю букву");
                arr[i] = s;
                Console.WriteLine(" буква была добавлена");
                i++;
            }
        }
        static bool CheckChar(char s)
        {
            bool x = true;
            int pause = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] == s && pause == 0)
                {
                    x = true;
                    pause++;
                }
            }
            if (pause == 0)
            {
                x = false;
            }
            return x;
        }
    }
}