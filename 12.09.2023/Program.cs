using System.Xml.Linq;

void sayHello()
{
    Console.WriteLine("hello");
}

sayHello();

/*тип_метода имя_метода (тип_параметра1 параметр1, тип_параметра2 параметр2, ...)
{
    //действия метода
}*/

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello work");
PrintMessage("Hello worl sec");
PrintMessage("Ok");

void Sum(int x, int y)
{
    int result = x + y;
    Console.WriteLine($"{x} + {y} = {result}");
}

Sum(10, 15);

void PrintPerson(string name, int age)
{
    Console.WriteLine($"{name} {age}");
}

PrintPerson("Tom", 24);

void PrintPerson2(string name1, int age1)
{
    Console.WriteLine($"Name: {name1} Age: {age1}");
}

byte b = 37;
PrintPerson2("Tom", b);


void PrintPerson3(string name3, int age3 = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name3}  Age: {age3}  Company: {company}");
}

PrintPerson3("Tom", 37, "Microsoft");
PrintPerson3("Tom", 37);
PrintPerson3("Tom");

void PrintPerson5(string name, int age)
{
    if(age > 120 || age < 1)
    {
        Console.WriteLine("Недопустимый возраст");
        return;
    }
    Console.WriteLine($"Имя: {name} Возраст: {age}");
}

PrintPerson5("Tom", 37);
PrintPerson5("Dunkan", 1234);


void Increment(ref int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}

int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(ref number);
Console.WriteLine($"Число после метода Increment: {number}");



void Sum2(int x, int y, out int result)
{
    result = x + y;
}

int number2;

Sum2(10, 15, out number);

Console.WriteLine(number);

void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
{
    rectArea = width * height;
    rectPerimetr = (width + height) * 2;
}

int area;
int perimetr;

GetRectangleData(10, 20, out area, out perimetr);

Console.WriteLine($"Площадь прямоугольника: {area}");
Console.WriteLine($"Периметр прямоугольника: {perimetr}");


//МАССИВ ПАРАМЕТРОВ И КЛЮЧЕВОЕ СЛОВО PARAMS

void Sum4(params int[] numbers)
{
    int result = 0;
    foreach(var n in numbers)
    {
        result += n;
    }

    Console.WriteLine(result);
}

int[] nums = { 1, 2, 3, 4, 5 };
Sum4(nums);
Sum4(1, 2, 3, 4);
Sum4(1, 2, 3);
Sum4();