// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void GetSumOddNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементоа массива -> {sum}");
}

void ShowRandomArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-99, 100);
        }
        Console.WriteLine($"[{String.Join(",", array)}]");
}

int size = 4;
int[] numbers = new int[size];
ShowRandomArray(numbers);
GetSumOddNumber(numbers);