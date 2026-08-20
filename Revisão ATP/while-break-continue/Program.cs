string inStr;
Console.WriteLine("Enter print, skip or exit: ");
inStr = Console.ReadLine();
int counter = 0;
while(inStr.ToLower() != "exit")
{
    if (inStr.ToLower() == "print")
        Console.WriteLine(counter);
    else if (inStr.ToLower() == "skip")
    {
        counter++;
        inStr = Console.ReadLine();
        continue;
    } else
        Console.WriteLine("Invalid entry, incrementing counter");
    counter++;
    inStr = Console.ReadLine();
}