// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// // Console.WriteLine(array[3]); //вызов алгоритма со сложностью О(1)

// // [4,5,3,1,2] // сумма эл-тов массива - сложность O(n) (О(5))
// // [1,2,3,4,5] // сортировка // - x быстрая сортировка - O(n * log n)
// // ((5 + 1)/2) * 5 - O(1)
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += array[i];
// }
// Console.WriteLine(sum);
// // O(n)

// // Таблица умножения O(n^2)
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }
// // сложность программы O(n^2)

// программа с массивом O(n^2 / 2)
// заполнение массива
    Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++) //здесь мы уменьшили кол-во итераций (для j)
    {
        matr[i, j] = (i + 1) * (j + 1); //для корректной таблицы умножения, тк начинаем с 0
        matr[j, i] = (i + 1) * (j + 1);
    }
}
    Console.WriteLine("Таблица:");

// печать массива
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matr[i, j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}

// сложность программы с тройной матрицей  - O(n^3 / 3)
