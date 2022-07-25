//task1
Console.Write("Введіть значення сорони квадрату: ");
int side = Convert.ToInt32(Console.ReadLine());
int area = (side * side);
int perimeter = (side * 4);
Console.WriteLine($"Площа : {area} Периметр: {perimeter}");
//task2
Thread.Sleep(5000);
Console.WriteLine("Як тебе звати? ");
string name = Console.ReadLine();
Console.WriteLine($"Скільки тобі років {name}");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{name} {age}");
//task3
Thread.Sleep(5000);
Console.WriteLine($"Введіть радіус кола: ");
double radius = Convert.ToDouble(Console.ReadLine());
double length = (2 * Math.PI * radius);
Console.WriteLine($"Довжина кола = {length:F2}");
double areas = (Math.PI * radius * radius);
Console.WriteLine($"Площа кола: {areas:F2}");
double volume = (Math.PI * radius * radius * radius * 4 / 3);
Console.WriteLine($"Об'єм: {volume:F2}");