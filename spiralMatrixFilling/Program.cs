// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] GenerateMatrix(){
    int[,] matrix = new int[,]{
        {01, 02, 03, 04},
        {12, 13, 14, 05},
        {11, 16, 15, 06},
        {10, 09, 08, 07},
    };
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

int[,] matr = GenerateMatrix();
PrintMatrix(matr);