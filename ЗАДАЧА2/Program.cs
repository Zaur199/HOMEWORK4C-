//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr = new int[123];
int count = 0;
int i = 0;
int j = 0;
while(i < arr.Length)
{
    arr[i] = new Random().Next(5, 660);
    Console.Write(arr[i] + " ");
    i++;
}

while(j < arr.Length)
{
    if(arr[j] > 9 && arr[j] < 100)
    {
        count++; 
    }
    j++;
}

Console.WriteLine();
Console.WriteLine("В массиве содержится следующее количество элементов из отрезка [10,99]: " + count);