﻿/*45. Напишите программу, которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования.*/

using System.Collections;

int[] array = {1, 9, 3, 12, 5};

int[] CopyArray(int[] array)
{
    int[] arrayL = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayL[i] = array[i];
    }
    return arrayL;
}

int[] userArray = CopyArray(array);


void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
}

PrintArray(userArray);
