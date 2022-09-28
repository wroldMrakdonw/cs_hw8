// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] matrixProduct(int[,] matrixA, int[,] matrixB){
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if(matrixA.GetLength(1) == matrixB.GetLength(0)){
        int tempSum;
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                tempSum = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                        tempSum += matrixA[i, k] * matrixB[k, j];
                }
                matrixC[i, j] = tempSum;
            }
        }}
    return matrixC;
}

int[,] A = GenerateMatrix(2, 2, 0, 10);
int[,] B = GenerateMatrix(2, 2, 0, 10);
PrintMatrix(A);
PrintMatrix(B);
PrintMatrix(matrixProduct(A, B));