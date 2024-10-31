
Console.WriteLine("Input a = :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input (+, -, *, /) = :");
string operation  = Console.ReadLine();
Console.WriteLine("Input b = :");
int b = Convert.ToInt32(Console.ReadLine());
int c=0;
if(operation=="+") c = a+b;
if(operation=="-") c = a-b;
if(operation=="*") c = a*b;
if(operation=="/") c = a/b;
Console.WriteLine($"Output: {c}");

