// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Generate3DArray(int Dimention1, int Dimention2, int Dimention3, int min, int max){
    int[,,] array = new int[Dimention1, Dimention2, Dimention3];
    for (int i = 0; i < Dimention1; i++)
    {
        for (int j = 0; j < Dimention2; j++)
        {
            for (int k = 0; k < Dimention3; k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,,] arr = Generate3DArray(2, 2, 2, 0, 11);
Print3DArray(arr);