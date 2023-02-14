int a = 645, b=78, c=32679;

char[] arrA = a.ToString().ToArray();
char[] arrB = b.ToString().ToArray();
char[] arrC = c.ToString().ToArray();

if (arrA.Length>=3)Console.WriteLine ($"\nThird Digit of {a} is: " + arrA[2]);
else Console.WriteLine ("Third Digit is absent");

if (arrB.Length>=3)Console.WriteLine ($"\nThird Digit of {b} is: " + arrB[2]);
else Console.WriteLine ("\nThird Digit is absent");

if (arrC.Length>=3)Console.WriteLine ($"\nThird Digit of {c} is: " + arrC[2]);
else Console.WriteLine ("\nThird Digit is absent");

