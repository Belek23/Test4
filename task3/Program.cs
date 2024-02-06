// Создание массива на 10 произвольных целых числе.
// Вывести на экран чётные элелменты массива.

//int n = 10;
//int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
//int i = 0;

//while (i < n)
//{
//    if (array[i] % 2 == 0)
//    {
//        System.Console.Write($"{array[i]} ");
//    }
//    i = i + 1;
//}


// Другой вариант

int[] array = { 3, 4, 5, 8, 12, 35, 4, 5, 8, 10 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}