/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int ShowSum(int[] array)
{
    int result =0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i]%2==0) result=result+1;
    }
    return result;
}


int min = 100;
int max = 999;

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(length, min, max);
ShowArray(myArray);

Console.WriteLine($"The sum of chetnyh numbers is {ShowSum(myArray)}");
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных позициях.
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) //i-первый работй элемент(не минимальнео значение).если из начала в конец i--
        array[i]=new Random().Next(minValue, maxValue+1);
        //перевое знаечение включается, а второе -нет, поэтому +1 ставим, чтобы включалось)
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int ShowSumofNech(int[] array)
{
    int result=0;
    for(int i =1; i<array.Length; i+=2)
    {
        result += array[i];
    }
    return result;

}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray=CreateRandomArray(length, min, max);
ShowArray(myArray);

Console.WriteLine($"Sum of nechetnyh positions is: {ShowSumofNech(myArray)}");
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
*/

double[] CreateArray(int size)
{
    double[] array = new double[size]; 

    for(int i=0; i < array.Length; i++)
    {
    Console.WriteLine($"Input {i+1} element");
        double element=Convert.ToDouble(Console.ReadLine());
        array[i]=element;
    } return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}
double ShowMax(double[] array)
{
    double max = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i]>max) max=array[i];
    }
    return max;
}
double ShowMin(double[] array)
{
    double min=array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min) min=array[i];
    }
    return min;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] MyArray = CreateArray(length);
ShowArray(MyArray);
double result=ShowMax(MyArray)-ShowMin(MyArray);
Console.WriteLine($"min is: {ShowMin(MyArray)}");
Console.WriteLine($"max is: {ShowMax(MyArray)}");
Console.WriteLine($"The difference between min and max is {result}");