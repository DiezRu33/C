
int num;
int num_2;
int num_3;

Console.WriteLine("Input the first number: ");
Console.WriteLine("Input the second number: ");
Console.WriteLine("Input the third number: ");

// Convert to int 32 bits
num = Convert.ToInt32(Console.ReadLine());
num_2 = Convert.ToInt32(Console.ReadLine());
num_3 = Convert.ToInt32(Console.ReadLine());

int result = num * num_2;
Console.WriteLine("The answer is: " + result + "light years away and " + num_3 + " years old.");
