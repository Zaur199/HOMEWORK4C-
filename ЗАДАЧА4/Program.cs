// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] arr ={23, 8, 6, 89, -19, 90, 6, 42, 0};
int index = 0;
int max = arr[0];
int min = arr[0];

while(index < arr.Length)
{
    if(arr[index] > max) max = arr[index];
    if(arr[index] < min) min = arr[index];
    index++;
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом в массиве равна: " + (max - min));