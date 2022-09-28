// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void CopyArrayToRow(int[] array, int[,] matrix, int row){
    for (int i = 0; i < array.Length; i++){
        matrix[row, i] = array[i];
    }
}

int[] CopyRowToArray(int[,] matrix, int row){
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < array.Length; i++){
        array[i] = matrix[row, i];
    }
    return array;
}

void ReverseArray(int[] array){
    int temp;
    for (int i = 0; i < array.Length / 2; i++){
        temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int[,] SortRows(int[,] matrix){
    int[] currentRow;
    int[,] sortedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++){
        currentRow = CopyRowToArray(matrix, i);
        Array.Sort(currentRow);
        ReverseArray(currentRow);
        CopyArrayToRow(currentRow, sortedMatrix, i);
    }
    return sortedMatrix;
}

int[,] matr = GenerateMatrix(3, 4, 0, 10);
PrintMatrix(matr);
int[,] sortedMatr = SortRows(matr);
PrintMatrix(sortedMatr);