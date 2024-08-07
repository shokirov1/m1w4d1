using m1w4d1.Task1;
using m1w4d1.Task2;
using m1w4d1.Task3;
using m1w4d1.Task4;
using m1w4d1.Task5;

//Task-1

Console.WriteLine();
Console.WriteLine("---------------------Task-1---------------------");
Console.WriteLine();
Circle circle = new Circle();
circle.Dram();
Rectangle rectangle = new Rectangle();
rectangle.Dram();

//Task-2

Console.WriteLine();
Console.WriteLine("---------------------Task-2---------------------");
Console.WriteLine();
int[] arr = new int[3] { 1, 2, 3 };
SumProcessor sumProcessor = new SumProcessor();
AverageProcessor averageProcessor = new AverageProcessor();
MaxProcessor maxProcessor = new MaxProcessor();
Console.WriteLine($"Sum : {sumProcessor.ProcessData(arr)}");
Console.WriteLine($"Average : {averageProcessor.ProcessData(arr)}");
Console.WriteLine($"Max : {maxProcessor.ProcessData(arr)}");

//Task-3

Console.WriteLine();
Console.WriteLine("---------------------Task-3---------------------");
Console.WriteLine();
double x = 10;
double y = 5;
Addition addition = new Addition();
Subtraction subtraction = new Subtraction();
Multiplication multiplication = new Multiplication();
Division divideision = new Division();
Console.WriteLine($"Addition : {addition.Calculate(x,y)}");
Console.WriteLine($"Subtraction : {subtraction.Calculate(x, y)}");
Console.WriteLine($"Multiplication : {multiplication.Calculate(x, y)}");
Console.WriteLine($"Division : {divideision.Calculate(x, y)}");

//Task-4

Console.WriteLine();
Console.WriteLine("---------------------Task-4---------------------");
Console.WriteLine();
string text = "hello ";
UppercasePlugin uppercasePlugin = new UppercasePlugin();
ReversePlugin reversePlugin = new ReversePlugin();
ReplaceSpacesPlugin replaceSpacesPlugin = new ReplaceSpacesPlugin();
Console.WriteLine($"UppercasePlugin : {uppercasePlugin.Execute(text)}");
Console.WriteLine($"ReversePlugin : {reversePlugin.Execute(text)}");
Console.WriteLine($"ReplaceSpacesPlugin : {replaceSpacesPlugin.Execute(text)}");

//Task-5

Console.WriteLine();
Console.WriteLine("---------------------Task-5---------------------");
Console.WriteLine();
Warrior warrior = new Warrior();
Mage mage = new Mage();
Archer archer = new Archer();
Console.WriteLine($"{warrior.Attack()}");
Console.WriteLine($"{mage.Attack()}");
Console.WriteLine($"{archer.Attack()}");
Console.WriteLine();
Console.ReadKey();