Console.WriteLine("\nInput Three-Digit number:");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 & a<1000)
{
  char[] array = a.ToString().ToCharArray();
  Console.WriteLine("Second Digit of the number is: " + array[1]);
} 
else 
{
Console.WriteLine("This is not Three-Digit number!");
}
