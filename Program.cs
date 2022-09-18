// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку местами.
/*
int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(-9,11);
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

int[,] Replace (int [,] array){
    int lengthOfArray=array.GetLength(0);
    int tmp=0;
    for (int j=0; j<array.GetLength(1);j++){
        tmp=array[lengthOfArray-1,j];
        array[lengthOfArray-1,j]=array[0,j];
        array[0,j]=tmp;
            
            } 
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
ShowArray (Replace(arr));
*/

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. Если это невозможно, 
//вывести сообщение на экран

int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(0,9);
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

int[,] Replace (int [,] array){
    int lengthOfRows=array.GetLength(0);
    int lengthOfCols=array.GetLength(1);
    int tmp=0;
    int[,]arr=new int[lengthOfRows,lengthOfCols];
    for (int i=0; i<arr.GetLength(0);i++){
        for (int j=0; j<arr.GetLength(1);j++){
            arr[i,j]=array[i,j];
        }}
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            if(array[i,j]==arr[i,j]){
            tmp=array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=tmp;
        }
            } }return array;
            }  
Console.WriteLine("Input number of rows of array: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of cols of array: ");
int cols=Convert.ToInt32(Console.ReadLine());
if (rows!=cols){
    Console.WriteLine("Input number of rows equals cols  of array");
}
else{
int [,] arr=CreateRandomArray(rows,cols);
Console.WriteLine("Array:");
ShowArray(arr);
Console.WriteLine("");
ShowArray (Replace(arr));
}
// Задайте двумерный массив из целых чисел. Удаляем строку на столбец на пересечении 
//которых расположен наименьший элемент массива. 
/*
int[,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j]=new Random().Next(0,10);
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

int[,] Remove (int [,] array){
    int lengthOfArray=array.GetLength(0);
    int min=array[0,0];
    int rowsofMin=0;
    int colsofMin=0;
    for (int i=0; i<array.GetLength(1);i++){
    for (int j=0; j<array.GetLength(1);j++){
        if(array[i,j]<min){
        min=array[i,j];
        rowsofMin=i;
        colsofMin=j;
        } }}
for (int i=0; i<array.GetLength(1);i++){
    for (int j=0; j<array.GetLength(1);j++){
        if (i==rowsofMin){
            array[i,j]=0;
                    }
if (j==colsofMin){
            array[i,j]=0;
                    }}}

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
ShowArray (Remove(arr));
*/