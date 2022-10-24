// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
int[] numbers = StringOfNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringOfNum(string enter)
{
    int count = 1;
    for (int i = 0; i < enter.Length; i++)
    {
        if (enter[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < enter.Length; i++)
    {
        string temp = "";

        while (enter [i] != ',')
        {
        if(i != enter.Length - 1)
        {
            temp += enter [i].ToString();
            i++;
        }
        else
        {
            temp += enter [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
