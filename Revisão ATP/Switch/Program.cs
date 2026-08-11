using System;
class program
{
    static void Main()
    {
        int op;
        Console.Write("Digite x: ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                if (Console.CapsLock)
                    Console.WriteLine("O NumLock está Ligado");
                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            case 3:
                Console.Beep(1000, 1500);
                Console.Beep(1000, 1500);
                Console.Beep(1000, 1500);
                break;
            default:
                Console.WriteLine("Opção Inválida !!!");
                break;
        }
    } 
}