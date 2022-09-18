//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Работает только для матрицы 4*4!
/*
int [,] CreateRandomArray (int rows,int cols){
    int[,] array=new int [rows,cols];
    int count=1;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (array[0,j] == 0) {
                array[0,j] = count;
                count++;
                }}
        if (i >= 1) {
            array[i,array.GetLength(1) - 1] = count;
            count++;
            }}

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 2; j >= 0; j--) {
            while (array[array.GetLength(0) - 1,j] == 0) {
                array[array.GetLength(0) - 1,j] = count;
                count++;
                }
            }

        while (array[i,0] == 0) {
            for (i = array.GetLength(0)-1; i > 0; i--) {
                if (array[i,0] == 0) {
                    array[i,0] = count;
                    count++;

                    }}
                }
            }

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            if (array[i,j] == 0) {
                array[i,j] = count;
                count++;
                if (i == 2) {
                    array[i,j] = count;
                    array[i,j + 1] = count - 1;

                    }
                }
            }
        }

    return array;}

void ShowArray (int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Console.Write(array[i,j]+" ");
    }
        Console.WriteLine(" ");
}}

Console.WriteLine("Array:");
ShowArray(CreateRandomArray(4,4));
*/

