// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateMatrix(int rows, int columns, int min, int max){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            matrix[i, j] = new Random().Next(min,max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] CopyRowToArray(int[,] matrix, int row){
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < array.Length; i++){
        array[i] = matrix[row, i];
    }
    return array;
}

int ArraySum(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        sum += array[i];
    }
    return sum;
}

int MinRowSum(int[,] matrix){
    int currentRowSum;
    int minSumRow = 0;
    int minSum = ArraySum(CopyRowToArray(matrix, 0));
    for (int i = 1; i < matrix.GetLength(0); i++){
        currentRowSum = ArraySum(CopyRowToArray(matrix, i));
        if(currentRowSum < minSum){
            minSum = currentRowSum;
            minSumRow = i + 1;
        }
    }
    return minSumRow;
}

int[,] matr = GenerateMatrix(4, 4, -10, 11);
PrintMatrix(matr);
System.Console.WriteLine(MinRowSum(matr));