/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();

int[] ConvertStringToInteger(string[] str) 
{
    int[] array = new int[str.Length];
    for(int i=0; i < str.Length; i++) 
    {
        array[i] = Convert.ToInt32(str[i]);
    }
    return array;
}

int CounterGreaterZero(int[] array) 
{
    int count = 0;
    foreach(int element in array) 
    {
        if(element > 0) count++;
    }
    return count;
}

Console.Write("Введите целые числа через запятую: ");
string numbers = Console.ReadLine();

int[] numberArray = ConvertStringToInteger(numbers.Split(','));

Console.WriteLine($"Количество чисел больше нуля = {CounterGreaterZero(numberArray)}");