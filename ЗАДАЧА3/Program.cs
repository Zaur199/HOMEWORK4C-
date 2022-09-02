// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int size = 18;
int[] arr = new int[size];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 18);
    Console.Write(" " + arr[i]);
} 
Console.WriteLine();

//Введём новую переменную
int j = arr.Length - 1;

for(int i = 0; i < (arr.Length +1)/2; i++)
{
    Console.Write(" " + (arr[i] * arr[j]));
    j = j -1;
}
Console.WriteLine();