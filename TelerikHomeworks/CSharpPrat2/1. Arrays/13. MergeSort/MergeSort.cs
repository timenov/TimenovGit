//Write a program that sorts an array of integers using the merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        Console.Write("Array length: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("enter elements:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] sorted = SplitAndSort(array);
        foreach (int item in sorted)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
	}
	
	static int[] SplitAndSort(int[] mainArr)
    {
		if (mainArr.Length == 1)
        {
			return mainArr;
		}

		int midd = mainArr.Length / 2;
		int[] leftArr = new int[midd];
		int[] rightArr = new int[mainArr.Length - midd];
		
        //fill leftArr[]
		for (int i = 0; i < midd; i++){
			leftArr[i] = mainArr[i];
		}
		//fill rightArr[]
		for (int i = 0; i < mainArr.Length - midd; i++){
			rightArr[i] = mainArr[midd+i];
		}

		leftArr = SplitAndSort(leftArr);
		rightArr = SplitAndSort(rightArr);
		return Mergesort(leftArr, rightArr);
	}
	static int[] Mergesort(int[] arr1, int[] arr2)
    {
		int[] arr3 = new int[arr1.Length + arr2.Length];
		int x = 0, i = 0, j = 0;
		while (i < arr1.Length && j < arr2.Length)
        {
			if (arr1[i] < arr2[j])
            {
				arr3[x] = arr1[i];
				i++;
			}
            else
            {
				arr3[x] = arr2[j];
				j++;
			}
			x++;
		}
		if (i < arr1.Length)
        {
			while(i < arr1.Length)
            {
				arr3[x] = arr1[i];
				i++;
                x++;
			}
		}
        else
        {
			while(j < arr2.Length)
            {
				arr3[x] = arr2[j];
				j++;
                x++;
			}
		}
		return arr3;
	}
}