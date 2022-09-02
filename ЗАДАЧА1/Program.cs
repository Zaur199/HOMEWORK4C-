//Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите число: a" );
int[] array = {1, 3, 5, 9, 1, -4, -7, 56, -113};
int n = array.Length;
int a = int.Parse(Console.ReadLine());
int find = a;
int i = 0;
while(i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine("СТОП: ДАННОЕ ЧИСЛО НАШЛОСЬ В УКАЗАННОМ МАССИВЕ. РЕЗУЛЬТАТ ПРИНЯТЬ ЗА ИСТИНУ");
        break;
    }
    
    else
        Console.WriteLine("Данного числа нет в массиве");
        
i++;

}

