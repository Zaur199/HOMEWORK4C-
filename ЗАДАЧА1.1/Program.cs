//Определить, присутствует ли в заданном массиве, некоторое число
//ДРУГОЙ ВАРИАНТ РЕШЕНИЯ
bool FindElement(int[] arr, int a )
{
    int i = 0;
    bool result = false;
    for(i = 0; i < arr.Length; i++)
    {
        if(arr[i] == a)
        {
            result = true;
        }
    }
    return result;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int[] arr = {5, 9, 78, 6, -8, 0, -45, 21, -1, 4};
if(FindElement(arr, a ) == true)
{
   Console.WriteLine($"Число {a} входит в массив"); 
}

else
    Console.WriteLine($"Число {a} не входит в массив");

Console.WriteLine();