/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
сравниваем парами и ставим на первое место меньшее число:
    3 > 1
    [1, 3, 5, 0, 7, 9, 8]
    3 < 5 ок
    5 > 0 меняем местами 5 и 0 и идём дальше с эл-та перестановки
    [1, 3, 0, 5, 7, 9, 8]
    5 < 7 ок
    7 < 9 ок
    9 > 8 меняем местами 5 и 0 и идём дальше
0) [1, 3, 0, 5, 7, 8, 9]
    1 < 3 ок
    3 > 0 меняем и идём дальше с эл-та перестановки
    [1, 0, 3, 5, 7, 8, 9]
    0 < 3 ok
    3 < 5 ok
    ...
    8 < 9 ok
1) [1, 0, 3, 5, 7, 8, 9]
    1 > 0 меняем и заново
2) [0, 1, 3, 5, 7, 8, 9]


*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n - 1; i++) //кол-во проходов
{
    for (int j = 0; j < n - 1; j++) //проход по самому массиву
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
