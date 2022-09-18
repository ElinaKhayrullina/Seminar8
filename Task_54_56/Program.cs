// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(1,10);
    }}
    return array; 
    }

void ShowArray (int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Console.Write(array[i,j]+" ");
    }
    Console.WriteLine(" ");
}}

int[,] Sort (int [,] array){
    int tmp=0;
    int count =0;
    for (int i=0; i<array.GetLength(0);i++){
        count=0;
        for (int j=0; j<array.GetLength(1)-1;j++){
            if(array[i,j+1]>array[i,j]){
                tmp=array[i,j+1];
                array[i,j+1]=array[i,j];
                array[i,j]=tmp;
                count++;
                } 
        if (count!=0){
        for (int k=0; k<array.GetLength(0);k++){
            count=0;
            for (int n=0; n<array.GetLength(1)-1;n++){
                if(array[k,n+1]>array[k,n]){
                    tmp=array[k,n+1];
                    array[k,n+1]=array[k,n];
                    array[k,n]=tmp;
                    count++;
        } 
        } }}}}
    return array;
        }

Console.WriteLine("Input number of rows of array: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of cols of array: ");
int cols=Convert.ToInt32(Console.ReadLine());

int [,] arr=CreateRandomArray(rows,cols);
Console.WriteLine("Array:");
ShowArray(arr);
Console.WriteLine("");
ShowArray (Sort(arr));
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.
/*
int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(1,10);
    }}
    return array; 
    }

void ShowArray (int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Console.Write(array[i,j]+" ");
    }
    Console.WriteLine(" ");
}}

void Sum (int [,] array){
    int sum =0;
    int [] sumArray=new int [array.GetLength(0)];
    int numberOfRows=0;
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1)-1;j++){
            sum+=array[i,j];
    }
    sumArray[i]=sum;
    sum=0;
    }
    int min=sumArray[0]; 
     for (int i=0; i<sumArray.GetLength(0);i++){
        if(sumArray[i]<min){
            min=sumArray[i];
            numberOfRows=i;
        }}
        Console.WriteLine($"Number of rows with min sum of elements is: {numberOfRows}");
        }

Console.WriteLine("Input number of rows of array: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of cols of array: ");
int cols=Convert.ToInt32(Console.ReadLine());
if (rows==cols){
    Console.WriteLine("Input number of cols and rows for  rectangular array: ");
}
else{
int [,] arr=CreateRandomArray(rows,cols);
Console.WriteLine("Array:");
ShowArray(arr);
Console.WriteLine("");
Sum(arr);}
*/

