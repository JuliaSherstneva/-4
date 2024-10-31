// Составьте программу, которая в зависимости от введенного числа n<=7,
// выводит на экран день недели и сообщение, рабочий день или выходной.

int n;
Console.Write("Введите n=");
n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        Console.WriteLine("Понедельник-" + "Рабочий день");
        break;
    case 2:
        Console.WriteLine("Вторник-" + "Рабочий день");
        break;
    case 3:
        Console.WriteLine("Среда-" + "Рабочий день");
        break;
    case 4:
        Console.WriteLine("Четверг-" + "Рабочий день");
        break;
    case 5:
        Console.WriteLine("Пятница-" + "Рабочий день");
        break;
    case 6:
        Console.WriteLine("Суббота-" + "Выходной");
        break;
    case 7:
        Console.WriteLine("Воскресение-" + "Выходной");
        break;
    default:
        Console.WriteLine("Не существует");
        break;
}
Console.ReadLine();
