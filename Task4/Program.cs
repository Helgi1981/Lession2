// Задача №3. Гири
// Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири.

// Вариант №1:

// int n = 5;
// int[] array = { 2, 4, 7, 3, 9 };
// int i = 0;
// int max = array[0];

// while (i < array.Length)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// Вариант №2:

// int[] array = { 2, 4, 7, 3, 9 };
// int max = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine(max);

// Вариант №3:

int[] array = { 2, 4, 7, 3, 9 };
int max = array[0];

foreach (int i in array)
{
    if (i > max)
    {
        max = i;
    }
}
Console.WriteLine(max);
