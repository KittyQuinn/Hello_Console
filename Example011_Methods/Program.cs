// Types of methods

// 1 type. Ничего не возвращают и ничего не принимают.

void Method1()
{
     Console.WriteLine("Hello, world!");
}
// Method1();

// 2 type. Ничего не возвращают но принимают аргумент(-ы).

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Hello, world!");


void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Hello,world!", count: 4);

// 3 type. Возвращают но не принимают.

int Method3()
{
    return DateTime.Now.Month;
}
// int month = Method3();
// Console.WriteLine(month);

// 4 type. Возвращают И принимают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "A");
Console.WriteLine(res);
