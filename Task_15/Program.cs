 Console.WriteLine("Input number of week day to find out if it's day off");
 int a = Convert.ToInt32(Console.ReadLine());

if (a>0 & a<8)
{
        if (a==6 || a==7)
    {
    System.Console.WriteLine("Yes, it's true!");
    }
    else
    {
    System.Console.WriteLine("No, it's working day.");
    }
}
else
System.Console.WriteLine("Wrong number!");
      